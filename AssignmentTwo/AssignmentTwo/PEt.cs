using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace AssignmentTwo
{
    class Pet
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string petType { get; set; }
        public int age { get; set; }
        public int OwnerTag { get; set; }


        public string IsValid()
        {
            if (Name == null) return "Name not set";

            if (petType == null) return "Pet Type not set";

            if (age == null) return "Age not set";

            if (OwnerTag == null) return "Owner tag not set";

            return null;

            return $"Name: {Name}\nPet Type: {petType:C}\nAge: {age}\nOwner Tag: {OwnerTag}";
        }
    }
}
