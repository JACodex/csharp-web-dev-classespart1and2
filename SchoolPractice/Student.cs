using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; } = 0;
        public double Gpa { get; set; }

        private static int nextId = 0;
        public Student(string name, int studentId, int numberOfCredits, double gpa) {
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
            StudentId = nextId;
            nextId++;
         }
    }
}
