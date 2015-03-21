using System.Data.Entity;

namespace EntityFrameworkIQAndIM
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("StudentConnectionString")
        {
            
        }
        public DbSet<Stduent> Students { get; set; }
    }
}