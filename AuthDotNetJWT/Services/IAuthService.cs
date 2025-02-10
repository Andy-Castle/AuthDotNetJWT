using AuthDotNetJWT.Entities;
using AuthDotNetJWT.Models;

namespace AuthDotNetJWT.Services
{
    public interface IAuthService
    {
        Task<User> Create(CreateUserDto createUserDto);

        Task<LoginResponse> Register(CreateUserDto registerDto);

        Task<LoginResponse> Login(LoginDto loginDto);

        Task<IEnumerable<User>> FindAll();

        Task<User?> FindById(Guid id);

        string GetJwtToken(Guid id);
    }
}
