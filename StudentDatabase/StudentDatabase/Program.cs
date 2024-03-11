using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {

                // Add a student
                Console.WriteLine("Enter your First Name: ");
                var fname = Console.ReadLine();
                Console.WriteLine("Enter your Last Name: ");
                var lname = Console.ReadLine();

                var newStudent = new Student
                {

                    FirstName = fname,
                    LastName = lname
                };
                context.Students.Add(newStudent);
                context.SaveChanges();

                // Retrieve and display the added student
                var addedStudent = context.Students.Find(newStudent.Id);
                Console.WriteLine($"Student Added: {addedStudent.FirstName} {addedStudent.LastName}");

                Console.WriteLine("\n\nPress any key to exit...");
                Console.ReadKey();
                return;
            }
          
            
        }
    }

    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
