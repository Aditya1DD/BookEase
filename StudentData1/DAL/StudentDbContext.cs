using StudentData1.Models.DBEntities;
using Microsoft.EntityFrameworkCore;
namespace StudentData1.DAL
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

		//myDbContext.Database.CommandTimeout = 300;
    }
}
