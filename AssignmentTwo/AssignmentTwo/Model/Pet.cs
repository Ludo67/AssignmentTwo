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
        public string PetID { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }

    }
}
