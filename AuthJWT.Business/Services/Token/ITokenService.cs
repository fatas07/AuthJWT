using AuthJWT.Business.Models.Token;
using AuthJWT.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWT.Business.Services.Token
{
    public interface ITokenService
    {
        TokenModel CreateToken(UserEntity user, IList<string> userRoles);
    }
}
