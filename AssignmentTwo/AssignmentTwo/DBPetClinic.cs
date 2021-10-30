using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    public class DBPetClinic
    {
        readonly SQLiteAsyncConnection database;

        public DBPetClinic(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
            database.CreateTableAsync<Vet>().Wait();
            database.CreateTableAsync<Pet>().Wait();
        }

        public Task<int> SaveVetAsync(Vet vet)
        {
            return database.InsertAsync(vet);
        }
        public Task<List<Vet>> GetVetsAsync()
        {
            return database.Table<Vet>().ToListAsync();
        }
    }
}
