using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentTwo
{
    class DBPetClinic
    {
        readonly SQLiteAsyncConnection database;

        public DBPetClinic(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
            database.CreateTableAsync<Vet>().Wait();
            database.CreateTableAsync<Pet>().Wait();
        }
    }
}
