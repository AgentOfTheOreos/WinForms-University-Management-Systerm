using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAppTaskFinal.DataModels.Persons.Students
{
    [Serializable]
    public class Exerciser : Student
    {
        public List<Course> CoursesForExercising { get; set; }

        public Exerciser(int id, string firstName, string lastName, int age, string phoneNumber, string email,
            string password, int studentNumber, string specialization, Track academicTrack, double balance,
            double currentYearlyDrain, double totalYearlyDrain) :
            base(id, firstName, lastName, age, phoneNumber, email, password,
            studentNumber, specialization, academicTrack, balance, currentYearlyDrain, totalYearlyDrain)
        {
            CoursesForExercising = new List<Course>();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" Courses for Exercising: {string.Join(", ", CoursesForExercising)}";
        }

        public string SimplifiedToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Courses exercised by exerciser: \n");
            foreach (var course in CoursesForExercising)
            {
                sb.AppendLine(course.SimplifiedToString());
            }
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Exerciser other)) return false;
            // Same object type
            const double epsilon = 1e-6;
            return base.Equals(other) &&
                   CoursesForExercising.SequenceEqual(other.CoursesForExercising) &&
                   Math.Abs(CurrentYearlyDrain - other.CurrentYearlyDrain) < epsilon &&
                   Math.Abs(TotalYearlyDrain - other.TotalYearlyDrain) < epsilon;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ CurrentYearlyDrain.GetHashCode();
                hashCode = (hashCode * 397) ^ TotalYearlyDrain.GetHashCode();
                hashCode = (hashCode * 397) ^ (Specialization != null ? Specialization.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ StudentNumber;
                hashCode = (hashCode * 397) ^ AcademicTrack.GetHashCode();
                hashCode = (hashCode * 397) ^ (CoursesForExercising != null ? CoursesForExercising.GetHashCode() : 0);
                return hashCode;
            }
        }
        public override string SubclassIdentifier
        {
            get => "Exerciser";
            set => throw new NotImplementedException();
        }
    }

}