using System;
using System.Collections.Generic;

namespace SchoolPractice
{



	public class Course
	{
		public string Subject { get; set; }
		public int MajorProjects { get; set; }
		public List<Student> EnrolledStudents { get; set; }

		public int CourseId { get; set; }

		private static int nextCourseId = 0;


            public Course(string subject, int majorProjects, List<Student>? enrolledStudents)
            {
				Subject = subject;
				MajorProjects = majorProjects;
				EnrolledStudents = enrolledStudents;
				CourseId = nextCourseId; 
				nextCourseId++; //every instance created of Course will increment the courseId. giving a faux uniqueId for each course

		}
		public Course(string subject, int majorProjects)
        {
			this.Subject = subject;
			this.MajorProjects = majorProjects;
        }
	}
}
