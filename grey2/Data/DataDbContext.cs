using grey2.Areas.Identity.Data;
using grey2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace grey2.Data
{
    public class DataDbContext : IdentityDbContext<ApplicationUser>
    {

        public DataDbContext(DbContextOptions<DataDbContext> options):base(options)
        {

        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}
