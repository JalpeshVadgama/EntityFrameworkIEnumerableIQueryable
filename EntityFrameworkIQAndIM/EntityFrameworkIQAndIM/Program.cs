using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkIQAndIM
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StudentContext studentContext = new StudentContext())
            {
                //IEnumerable way
                IEnumerable<Student> students = studentContext.Students.ToList();
                students = students.Where(s => s.Percentage > 70);
                PrintStudent(students);
            }            
        }

        private static void PrintStudent(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
            }
        }
    }
}
