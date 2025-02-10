using AuthDotNetJWT.Entities;

namespace AuthDotNetJWT.Models
{
    public class LoginResponse
    {
        public User User { get; set; }= null!;

        public string Token { get; set; } = string.Empty;
    }
}
