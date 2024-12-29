using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApi.Data
{
    public class UserDbContext : IdentityDbContext<IdentityUser>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        { 
        
        }
    }
}
