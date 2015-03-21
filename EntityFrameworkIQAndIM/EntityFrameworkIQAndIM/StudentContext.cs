using System.Data.Entity;

namespace EntityFrameworkIQAndIM
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("StudentConnectionString")
        {
            //default constructor for connection strings
        }
        public DbSet<Student> Students { get; set; }
    }
}