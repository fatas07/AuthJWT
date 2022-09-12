using AuthJWT.Business.Models.Base;
using AuthJWT.Business.Models.Login;
using AuthJWT.Business.Models.Register;
using AuthJWT.Business.Models.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWT.Business.Services.Auth
{
    public interface IAuthService
    {
        Task<ResponseModel> Login(LoginRequestModel loginRequestModel);
        Task<ResponseModel> Register(RegisterRequestModel registerRequestModel);
        Task<ResponseModel> RefreshToken(RefreshTokenRequestModel refreshTokenRequestModel);
    }
}
