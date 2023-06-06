using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers
{
    [Serializable]
    public class Lecturer : Person
    {
        public int EmployeeNumber { get; }
        public List<Course> CoursesTaught { get; set; }
        public string Specialization { get; }
        public int StarRating { get; }

        public Lecturer(int id, string firstName, string lastName, int age, string phoneNumber, string email,
            string password, int employeeNumber, string specialization, int starRating)
            : base(id, firstName, lastName, age, phoneNumber, email, password)
        {
            EmployeeNumber = employeeNumber;
            CoursesTaught = new List<Course>();
            Specialization = specialization;
            StarRating = starRating;
        }
        public Lecturer(int id, string firstName, string lastName, int age, string phoneNumber, string email,
            string password, int employeeNumber, List<Course> coursesTaught, string specialization, int starRating)
            : base(id, firstName, lastName, age, phoneNumber, email, password)
        {
            EmployeeNumber = employeeNumber;
            CoursesTaught = coursesTaught;
            Specialization = specialization;
            StarRating = starRating;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" Employee Number: {EmployeeNumber}\n" +
                   $" Courses Taught: {string.Join(", ", CoursesTaught)}\n" +
                   $" Specialization: {Specialization}\n" +
                   $" Star Rating: {StarRating}\n";
        }
        
        public string SimplifiedToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($" Employee Number: {EmployeeNumber}\n");
            sb.Append(" Courses taught by lecturer: \n");
            foreach (var course in CoursesTaught)
            {
                sb.AppendLine(course.SimplifiedToString());
            }

            sb.Append($" Specialization: {Specialization}\n");
            sb.Append($" Star Rating: {StarRating}\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Lecturer other))
                return false;

            return base.Equals(other) &&
                   EmployeeNumber == other.EmployeeNumber &&
                   CoursesTaught.SequenceEqual(other.CoursesTaught) &&
                   Specialization.Equals(other.Specialization) &&
                   StarRating == other.StarRating;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ EmployeeNumber;
                hashCode = (hashCode * 397) ^ (Specialization != null ? Specialization.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ StarRating;
                hashCode = CoursesTaught.Aggregate(hashCode, (current, course) =>
                    (current * 397) ^ (course != null ? course.GetHashCode() : 0));
                return hashCode;
            }
        }
        public override string SubclassIdentifier
        {
            get => "Lecturer";
            set => throw new NotImplementedException();
        }
    }
}
