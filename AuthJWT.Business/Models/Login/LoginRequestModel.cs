using System.ComponentModel.DataAnnotations;

namespace AuthJWT.Business.Models.Login
{
    public class LoginRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
