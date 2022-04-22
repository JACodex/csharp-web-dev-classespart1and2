using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Josh = new Student("Josh", 007, 1, 4.0);
            Student Kefka = new Student("Kefka", 001, 1, 4.5);
            List<Student> students = new List<Student> { Josh, Kefka };
            Course Potions = new Course("Potions", 3, students);
            Teacher Snape = new Teacher("Severus", "Snape", Potions, 12);
            Console.WriteLine($"Josh GPa is {Josh.Gpa}");
            Console.WriteLine($"{Snape.FirstName}  {Snape.LastName}   Course:  {Potions.Subject} Enrolled: " );
            foreach (Student student in Potions.EnrolledStudents)
            {
                Console.WriteLine(student.Name);
            }
            Dictionary<string, Student> Students2 = new Dictionary<string, Student>();
        }
    }
}
