using AuthJWT.Business.Helpers;
using AuthJWT.Business.Models;
using AuthJWT.Business.Models.Base;
using AuthJWT.Business.Models.Login;
using AuthJWT.Business.Models.Register;
using AuthJWT.Business.Models.Token;
using AuthJWT.Business.Services.Token;
using AuthJWT.Data.Repository.User;
using AuthJWT.Entities.Identity;
using AutoMapper;

namespace AuthJWT.Business.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepo userRepo;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;

        public AuthService(IUserRepo _userRepo, IMapper _mapper, ITokenService _tokenService)
        {
            userRepo = _userRepo;
            mapper = _mapper;
            this.tokenService = _tokenService;
        }
        public async Task<ResponseModel> Login(LoginRequestModel loginRequestModel)
        {
            var user = await userRepo.GetUserByEmail(loginRequestModel.Email);
            if (user == null || !await userRepo.CheckUserPassword(user, loginRequestModel.Password))
            {
                return new ResponseModelError { Error = ErrorHandlerHelper.INVALID_USER };
            }

            var loginResponseModel = new LoginResponseModel()
            {
                User = mapper.Map<UserModel>(user),
                Token = tokenService.CreateToken(user, await userRepo.GetUserRoles(user))
            };

            user.RefreshToken = loginResponseModel.Token.RefreshToken;
            user.RefreshTokenEndDate = loginResponseModel.Token.Expiration.AddHours(12); // Added 12 hours to access token exp.
            await userRepo.UpdateUser(user);

            return new ResponseModelOk<LoginResponseModel>() { payload = loginResponseModel };
        }

        public async Task<ResponseModel> Register(RegisterRequestModel registerRequestModel)
        {
            var user = await userRepo.GetUserByEmail(registerRequestModel.Email);

            if (user != null)
            {
                return new ResponseModelError
                {
                    Error = ErrorHandlerHelper.USER_EXIST
                };
            }

            var userEntity = mapper.Map<UserEntity>(registerRequestModel);
            userEntity.Language = "en-US";
            userEntity.Timezone = TimeZoneInfo.Utc.Id;
            userEntity.SecurityStamp = Guid.NewGuid().ToString();

            var result = await userRepo.CreateUser(userEntity, registerRequestModel.Password);

            if (!result.Succeeded)
            {
                return new ResponseModelError
                {
                    Error = ErrorHandlerHelper.UNKNOWN_REGISTER_ERROR
                };
            }
            await userRepo.AddDefaultRoleToUser(userEntity);

            return new ResponseModelOk();
        }

        public async Task<ResponseModel> RefreshToken(RefreshTokenRequestModel refreshTokenRequestModel)
        {
            var user = await userRepo.GetUserByEmail(refreshTokenRequestModel.Email);
            if (user == null)
            {
                return new ResponseModelError
                {
                    Error = ErrorHandlerHelper.USER_NOT_FOUND
                };
            }

            if (user.RefreshToken != refreshTokenRequestModel.RefreshToken || DateTime.UtcNow > user.RefreshTokenEndDate)
            {
                return new ResponseModelError
                {
                    Error = ErrorHandlerHelper.REFRESH_TOKEN_EXPIRED
                };
            }
            var loginResponseModel = new LoginResponseModel()
            {
                User = mapper.Map<UserModel>(user),
                Token = tokenService.CreateToken(user, await userRepo.GetUserRoles(user))
            };

            user.RefreshToken = loginResponseModel.Token.RefreshToken;
            user.RefreshTokenEndDate = loginResponseModel.Token.Expiration.AddHours(12); // Added 12 hours to access token exp.
            await userRepo.UpdateUser(user);

            return new ResponseModelOk<LoginResponseModel>() { payload = loginResponseModel };
        }
    }
}
