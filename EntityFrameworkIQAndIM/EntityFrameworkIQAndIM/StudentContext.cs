using System.Data.Entity;

namespace EntityFrameworkIQAndIM
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("StudentConnectionString")
        {
            Database.SetInitializer<StudentContext>(null);
        }
        public DbSet<Student> Students { get; set; }
    }
}