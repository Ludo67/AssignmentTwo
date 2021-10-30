using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AssignmentTwo
{
    public class Vet
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Specialization { get; set; }


        public string IsValid()
        {
            return FirstName == null
                ? "First name not set"
                : LastName == null
                ? "Last name not set"
                : PhoneNumber == null
                ? "Phone # not set"
                : Email == null
                ? "email not set"
                : Specialization == null
                ? "Specialization not set"
                : Username == null
                ? "Username not set"
                : Password.Length < 10
                ? "Password needs to be at least 10 characters"
                : $"First name: {FirstName}\nLast name: {LastName:C}\nEmail: {Email}\nPhone Number: {PhoneNumber}\nSpecialization: {Specialization}";
        }
    }
}
