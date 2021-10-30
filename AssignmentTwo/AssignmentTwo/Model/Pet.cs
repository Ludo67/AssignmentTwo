using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace AssignmentTwo
{
    public class Pet
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string PetType { get; set; }
        public int? Age { get; set; }
        public int? OwnerTag { get; set; }


        public string IsValid()
        {
            return Name == null
                ? "Name not set"
                : PetType == null
                ? "Pet Type not set"
                : Age == null
                ? "Age not set"
                : OwnerTag == null ? "Owner tag not set" : $"Name: {Name}\nPet Type: {PetType:C}\nAge: {Age}\nOwner Tag: {OwnerTag}";
        }
    }
}
