using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;

namespace WindowsFormsAppTaskFinal.DataModels
{
    [Serializable]
    public class Track : IEnumerable
    {
        public string TrackName { get; }
        public List<Student> EnrolledStudents { get; set; }
        public List<Course> IncludedCourses { get; set; }
        public Track(string trackName) 
        {
            TrackName = trackName;
            EnrolledStudents = new List<Student>();
            IncludedCourses = new List<Course>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Track Name: {TrackName}");
            sb.AppendLine("Enrolled Students:");
            foreach (var student in EnrolledStudents) sb.AppendLine($"- {student}");
            sb.AppendLine("Included Courses:");
            foreach (var course in IncludedCourses) sb.AppendLine($"- {course}");
            return sb.ToString();
        }
        
        public string SimplifiedToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Track Name: {TrackName}\n");
            sb.AppendLine("Enrolled Students:\n");
            foreach (var student in EnrolledStudents)
                sb.AppendLine($"- Full Name: {student.FirstName} {student.LastName}, ID: {student.Id}\n");
            sb.AppendLine("Included Courses:\n");
            foreach (var course in IncludedCourses)
                sb.AppendLine($"- Course Code: {course.CourseCode}\n, Course Name: {course.CourseName}\n, Course Description: {course.CourseDescription}.\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Track other)
            {
                return TrackName.Equals(other.TrackName) &&
                       EnrolledStudents.SequenceEqual(other.EnrolledStudents) &&
                       IncludedCourses.SequenceEqual(other.IncludedCourses);
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = TrackName != null ? TrackName.GetHashCode() : 0;
                hashCode = EnrolledStudents.Aggregate(hashCode, (current, student) => current * 23 + student.GetHashCode());
                hashCode = IncludedCourses.Aggregate(hashCode, (current, course) => current * 23 + course.GetHashCode());
                return hashCode;
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}