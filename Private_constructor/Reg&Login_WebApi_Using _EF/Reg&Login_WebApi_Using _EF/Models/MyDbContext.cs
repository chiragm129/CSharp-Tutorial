using Microsoft.EntityFrameworkCore;

namespace Reg_Login_WebApi_Using__EF.Models
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

            
        }

        public DbSet<User> Users { get; set; }
    }
}
