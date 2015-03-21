using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkIQAndIM
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int  StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Percentage { get; set; }
    }
}