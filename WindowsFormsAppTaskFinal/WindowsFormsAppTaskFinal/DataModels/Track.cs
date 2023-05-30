using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;

namespace WindowsFormsAppTaskFinal.DataModels
{
    [Serializable]
    public class Track
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
    }
}