using grey2.Models;
using Microsoft.EntityFrameworkCore;

namespace grey2.Data
{
    public class DataDbContext :DbContext
    {

        public DataDbContext(DbContextOptions<DataDbContext> options):base(options)
        {

        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}
