using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkIQAndIM
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StudentContext studentContext = new StudentContext())
            {
                //IEnumerable way
                //IEnumerable<Student> students = studentContext.Students.ToList();

                //IQueryable way
                IQueryable<Student> students = studentContext.Students;
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
