using AuthDotNetJWT.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthDotNetJWT.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
    }
}
