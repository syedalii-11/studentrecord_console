using System;
using System.Linq;
using StudentRecord;

class Program
{
    static void Main()
    {
        using (var context = new StudentDbContext())
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Add a student
            var student = new Student { Name = "John Doe", Age = 20 };
            context.Students.Add(student);
            context.SaveChanges();

            // Fetch and display student data
            var students = context.Students.ToList();
            Console.WriteLine("Student List:");
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }
        }
    }
}
