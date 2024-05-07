using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class ApplicationDbContext:DbContext
    {
       public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Aspf8;trusted_connection=true;trustServerCertificate=true");
        }
    }
}
