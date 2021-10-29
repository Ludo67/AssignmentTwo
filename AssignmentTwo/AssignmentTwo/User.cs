using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AssignmentTwo
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public string email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int OwnerTag { get; set; }


        public string IsValid()
        {
            if (firstName == null) return "First name not set";

            if (lastName == null) return "Last name not set";

            if (phoneNumber == null) return "Phone # not set";

            if (email == null) return "email not set";

            //if (OwnerTag == null) return "Tag not set";

            if (Username == null) return "Username not set";

            if (Password.Length < 10) return "Password needs to be at least 10 characters";

            return null;

            return $"First name: {firstName}\nLast name: {lastName:C}\nEmail: {email}\nPhone Number: {phoneNumber}";
        }
    } 
}
