using IdentityAuthentication.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityAuthentication.Context
{
    public class IdentityDatabaseContext : IdentityDbContext
    {
        public IdentityDatabaseContext(DbContextOptions<IdentityDatabaseContext> dbContextOptions): base(dbContextOptions)
        {
                
        }
        public DbSet<TestUser> TestUsers { get; set; }
    }
}
