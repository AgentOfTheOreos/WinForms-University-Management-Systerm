using System;

namespace WindowsFormsAppTaskFinal.DataModels.Persons.Students
{
    [Serializable]
    public class Student : Person
    {

        // Constructor
        public Student(int id, string firstName, string lastName, int age, string phoneNumber, string email,
            string password, int studentNumber, string specialization, Track academicTrack, double balance, double currentYearlyDrain,
            double totalYearlyDrain) : base(id, firstName, lastName, age, phoneNumber, email, password)
        {
            StudentNumber = studentNumber;
            Specialization = specialization;
            Balance = balance;
            CurrentYearlyDrain = currentYearlyDrain;
            TotalYearlyDrain = totalYearlyDrain;
            AcademicTrack = academicTrack;
        }
        public double Balance { get; }
        public double CurrentYearlyDrain { get; }
        public double TotalYearlyDrain { get; }
        public string Specialization { get; }
        public int StudentNumber { get; }
        public Track AcademicTrack { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                   $" Specialization = {Specialization} \n" +
                   $" Student Number = {StudentNumber} \n" +
                   $" Academic Track = {AcademicTrack.TrackName} \n" +
                   $" Balance = {Balance}$ \n" +
                   $" Current Yearly Drain = {CurrentYearlyDrain}$ \n" +
                   $" Total Yearly Drain = {TotalYearlyDrain}$] \n";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student other)) return false;
            const double epsilon = 1e-6;
            return base.Equals(other) &&
                   Math.Abs(Balance - other.Balance) < epsilon &&
                   Math.Abs(CurrentYearlyDrain - other.CurrentYearlyDrain) < epsilon &&
                   Math.Abs(TotalYearlyDrain - other.TotalYearlyDrain) < epsilon &&
                   Specialization.Equals(other.Specialization) &&
                   AcademicTrack.Equals(other.AcademicTrack);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ Balance.GetHashCode();
                hashCode = (hashCode * 397) ^ CurrentYearlyDrain.GetHashCode();
                hashCode = (hashCode * 397) ^ TotalYearlyDrain.GetHashCode();
                hashCode = (hashCode * 397) ^ (Specialization != null ? Specialization.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ StudentNumber;
                hashCode = (hashCode * 397) ^ AcademicTrack.GetHashCode();
                return hashCode;
            }
        }
        public override string SubclassIdentifier
        {
            get => "Student";
            set => throw new NotImplementedException();
        }
    }
}