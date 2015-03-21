using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkIQAndIM
{
    public class Stduent
    {
        [Key]
        public int  StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Percentage { get; set; }
    }
}