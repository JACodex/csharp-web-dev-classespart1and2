using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student billyTheStudent = new Student("Billy The Student");
            Student williamTheStudent = new Student("Billy The Student");
            //Console.WriteLine(billyTheStudent.GetGradeLevel(billyTheStudent.NumberOfCredits));
            //billyTheStudent.AddGrade(4, 3.0);
            //billyTheStudent.AddGrade(3, 4.0);
            //Console.WriteLine(billyTheStudent.Gpa);
            Console.WriteLine(billyTheStudent.ToString());
            Console.WriteLine(williamTheStudent.ToString());
            Console.WriteLine(billyTheStudent.Equals(billyTheStudent));
        }
    }
}
