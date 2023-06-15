using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;

namespace WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers
{
    [Serializable]
    public class TrackDirector : Lecturer
    {
        public List<Track> ResponsibleTracks { get; set; }
        public List<Student> Students { get; set; }
        public List<Person> Persons { get; set; }

        public TrackDirector(int id, string firstName, string lastName, int age, string phoneNumber, string email,
            string password, int employeeNumber, string specialization, int starRating)
            : base(id, firstName, lastName, age, phoneNumber, email, password, employeeNumber, specialization,
                starRating)
        {
            ResponsibleTracks = new List<Track>();
            Students = new List<Student>();
            Persons = new List<Person>();
        }

        public Person FindUserByEmail(string email)
        {
            if (Email.Equals(email))
                return this;
            foreach (var person in Persons.Where(person => person.Email.Equals(email)))
            {
                return person;
            }

            return Students.FirstOrDefault(student => student.Email.Equals(email));
        }
        
        public new string SimplifiedToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            foreach (var track in ResponsibleTracks)
            {
                sb.Append(track.SimplifiedToString());
            }

            foreach (var student in Students)
            {
                sb.Append(student);
            }

            foreach (var person in Persons)
            {
                sb.Append(person);
            }

            return sb.ToString();
        }
        public override string ToString()
        {
            var trackDirString = base.ToString();
            trackDirString += "Responsible for Tracks: \n";
            trackDirString = ResponsibleTracks.Aggregate(trackDirString, (current, track) => current + (track + "\n"));
            trackDirString += "Responsible for Students: \n";
            trackDirString = Students.Aggregate(trackDirString, (current, student) => current + (student + "\n"));
            trackDirString += "Responsible for Lecturers and Exercisers: \n";
            return Persons.Aggregate(trackDirString, (current, person) => current + (person + "\n"));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is TrackDirector other))
                return false;

            return base.Equals(other) &&
                   ResponsibleTracks.SequenceEqual(other.ResponsibleTracks) &&
                   Students.SequenceEqual(other.Students) &&
                   Persons.SequenceEqual(other.Persons);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                hashCode = ResponsibleTracks.Aggregate(hashCode, (current, track) => current * 23 + track.GetHashCode());
                hashCode = Students.Aggregate(hashCode, (current, student) => current * 23 + student.GetHashCode());
                hashCode = Persons.Aggregate(hashCode, (current, person) => current * 23 + person.GetHashCode());
                return hashCode;
            }
        }
        public override string SubclassIdentifier => "TrackDirector";
    }
}