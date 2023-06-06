using System;
using System.Collections.Generic;

namespace WindowsFormsAppTaskFinal.DataModels.Persons
{
    [Serializable]
    public abstract class Person
    {
        // Constructor
        protected Person(int id, string firstName, string lastName, int age, string phoneNumber, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            Messages = new List<Message>();
        }

        // Getters and Setters
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public string Password { get; }
        public List<Message> Messages { get; }

        public string PhotoFilePath => @"C:\Users\alaas\RiderProjects\WindowsFormsAppTaskFinal\WindowsFormsAppTaskFinal\Images\";
        public string FilePathWithEmail => $@"{PhotoFilePath}{Email}'s Photo.png";

        public override string ToString()
        {
            return $"Person[ID = {Id} \n" +
                   $" FirstName = {FirstName} \n" +
                   $" LastName = {LastName} \n" +
                   $" Age = {Age} \n" +
                   $" Phone Number = {PhoneNumber} \n" +
                   $" Email = {Email} \n" +
                   $" Messages = {Messages} \n";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
                // Same object type
                return Id == other.Id &&
                       FirstName.Equals(other.FirstName) &&
                       LastName.Equals(other.LastName) &&
                       Age == other.Age &&
                       PhoneNumber.Equals(other.PhoneNumber) &&
                       Email.Equals(other.Email) && 
                       Messages.Equals(other.Messages) &&
                       Password.Equals(other.Password) &&
                       GetHashCode() == other.GetHashCode();
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id;
                hashCode = (hashCode * 397) ^ (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Age;
                hashCode = (hashCode * 397) ^ (PhoneNumber != null ? PhoneNumber.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Email != null ? Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Password != null ? Password.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Messages != null ? Messages.GetHashCode() : 0);
                return hashCode;
            }
        }
        public abstract string SubclassIdentifier { get; set; }
    }
}