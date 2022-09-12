using AuthJWT.Entites.Identity;
using Microsoft.AspNetCore.Identity;

namespace AuthJWT.Data.Repository.User
{
    public interface IUserRepo
    {
        #region CREATE
        Task<IdentityResult> CreateUser(UserEntity user, string password);
        Task<IdentityResult> AddDefaultRoleToUser(UserEntity user);
        #endregion

        #region READ
        Task<UserEntity> GetUserByEmail(string email);
        Task<bool> CheckUserPassword(UserEntity user, string password);
        Task<IList<string>> GetUserRoles(UserEntity user);
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion

    }
}
