using AuthJWT.Business.Helpers;
using AuthJWT.Business.Models;
using AuthJWT.Business.Models.Base;
using AuthJWT.Data.Repository.User;
using AutoMapper;

namespace AuthJWT.Business.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepo userRepo;
        private readonly IMapper mapper;

        public UserService(IUserRepo _userRepo, IMapper _mapper)
        {
            userRepo = _userRepo;
            mapper = _mapper;
        }
        public async Task<ResponseModel> FindUserByEmail(string email)
        {
            var user = await userRepo.GetUserByEmail(email);
            if (user == null)
            {
                return new ResponseModelError { Error = ErrorHandlerHelper.USER_NOT_FOUND };
            }
            UserModel userModel = mapper.Map<UserModel>(user);
            return new ResponseModelOk<UserModel>() { payload = userModel };
        }
    }
}
