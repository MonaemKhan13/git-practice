using DemoProjectMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMVC.DbCon
{
    public class DbConnectionContext:DbContext
    {
        public DbConnectionContext(DbContextOptions<DbConnectionContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
