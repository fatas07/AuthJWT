using AuthJWT.Business.Models.Base;

namespace AuthJWT.Business.Services.User
{
    public interface IUserService
    {
        Task<ResponseModel> FindUserByEmail(string email);
    }
}
