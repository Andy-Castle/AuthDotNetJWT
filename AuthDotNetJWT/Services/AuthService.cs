using AuthDotNetJWT.Entities;
using AuthDotNetJWT.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthDotNetJWT.Services
{
    public class AuthService(DbContext context, IConfiguration configuration) : IAuthService
    {
        public Task<User> Create(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<User?> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string GetJwtToken(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> Login(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> Register(CreateUserDto registerDto)
        {
            throw new NotImplementedException();
        }
    }
}
