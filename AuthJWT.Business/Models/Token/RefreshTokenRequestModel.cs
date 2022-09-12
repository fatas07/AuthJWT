using System.ComponentModel.DataAnnotations;

namespace AuthJWT.Business.Models.Token
{
    public class RefreshTokenRequestModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string RefreshToken { get; set; }
    }
}
