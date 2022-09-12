using AuthJWT.Business.Models.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWT.Business.Models.Login
{
    public class LoginResponseModel
    {
        public TokenModel Token { get; set; }
        public UserModel User { get; set; }
    }
}
