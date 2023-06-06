using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;

namespace WindowsFormsAppTaskFinal.DataModels
{
    [Serializable]
    public class Course
    {
        public string CourseCode { get; } // Unique identifier for the course
        public string CourseName { get; } // Name of the course
        public string CourseDescription { get; } // Description of the course
        public List<Student> EnrolledStudents { get; set; }
        public DateTime StartDate { get; } // Start date of the course
        public DateTime EndDate { get; } // End date of the course

        public Course(string courseCode, string courseName, string courseDescription, DateTime startDate, DateTime
            endDate)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            CourseDescription = courseDescription;
            EnrolledStudents = new List<Student>();
            StartDate = startDate;
            EndDate = endDate;
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Course Code: {CourseCode}\n");
            sb.AppendLine($"Course Name: {CourseName}\n");
            sb.AppendLine($"Course Description: {CourseDescription}\n");
            sb.AppendLine("Enrolled Students in the course:\n");
            foreach (var student in EnrolledStudents)
            {
                sb.AppendLine($"- {student}\n");
            }
            sb.AppendLine($"Start Date: {StartDate:MM/dd/yyyy}\n");
            sb.AppendLine($"End Date: {EndDate:MM/dd/yyyy}\n");

            return sb.ToString();
        }
        
        public string SimplifiedToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Course Code: {CourseCode}\n");
            sb.AppendLine($"Course Name: {CourseName}\n");
            sb.AppendLine($"Course Description: {CourseDescription}\n");
            sb.AppendLine("Enrolled Students in the course:\n");
            foreach (var student in EnrolledStudents)
            {
                sb.AppendLine($"- Full Name: {student.FirstName} {student.LastName}, ID: {student.Id}\n");
            }
            sb.AppendLine($"Start Date: {StartDate:MM/dd/yyyy}\n");
            sb.AppendLine($"End Date: {EndDate:MM/dd/yyyy}\n");

            return sb.ToString();
        }

        public string ToStringStudentView()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Course Code: {CourseCode}");
            sb.AppendLine($"Course Name: {CourseName}");
            sb.AppendLine($"Course Description: {CourseDescription}");
            sb.AppendLine($"Start Date: {StartDate:MM/dd/yyyy}");
            sb.AppendLine($"End Date: {EndDate:MM/dd/yyyy}");
            return sb.ToString();
        }
        
        public override bool Equals(object obj)
        {
            if (obj is Course other)
            {
                return CourseCode.Equals(other.CourseCode) &&
                       CourseName.Equals(other.CourseName) &&
                       CourseDescription.Equals(other.CourseDescription) &&
                       EnrolledStudents.SequenceEqual(other.EnrolledStudents) &&
                       StartDate.Equals(other.StartDate) &&
                       EndDate.Equals(other.EndDate);
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + (CourseCode != null ? CourseCode.GetHashCode() : 0);
                hash = hash * 23 + (CourseName != null ? CourseName.GetHashCode() : 0);
                hash = hash * 23 + (CourseDescription != null ? CourseDescription.GetHashCode() : 0);
                hash = hash * 23 + StartDate.GetHashCode();
                hash = hash * 23 + EndDate.GetHashCode();
                hash = EnrolledStudents.Aggregate(hash, (current, student) => current * 23 + student.GetHashCode());
                return hash;
            }
        }
    }
}