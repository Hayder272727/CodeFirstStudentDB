using System;

namespace CodeFirstStudentDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student
                {
                    Name = "Ali"
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadLine();
        }
    }
}
