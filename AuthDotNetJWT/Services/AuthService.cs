using AuthDotNetJWT.Data;
using AuthDotNetJWT.Entities;
using AuthDotNetJWT.Models;
using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AuthDotNetJWT.Services
{
    public class AuthService(ApplicationDbContext context, IConfiguration configuration) : IAuthService
    {

        public async Task<User> Create(CreateUserDto createUserDto)
        {
            try
            {

                if (await context.Users.AnyAsync(u => u.Email == createUserDto.Email))
                {
                    throw new BadHttpRequestException($"{createUserDto.Email} ya existe");
                }

                var user = new User
                {
                    Name = createUserDto.Name,
                    Email = createUserDto.Email
                };

                var hashedPassword = new PasswordHasher<User>()
                        .HashPassword(user, createUserDto.Password);

                user.Password = hashedPassword;


                context.Users.Add(user);
                await context.SaveChangesAsync();

                return user;
            }
            catch (Exception ex) when (ex is not BadHttpRequestException)
            {
                string message = "Error al crear el usuario";

                throw new Exception($"Salio algo mal, {message}", ex);
            }
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
