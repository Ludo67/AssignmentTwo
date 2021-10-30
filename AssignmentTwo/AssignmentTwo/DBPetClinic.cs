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

        public Task<List<User>> GetUsers()
        {
            return database.Table<User>().ToListAsync();
        }

        public Task<int> RegisterUserAsync(User user)
        {
            return database.InsertAsync(user);
        }

        public Task<int> RegisterPetAsync(Pet pet)
        {
            return database.InsertAsync(pet);
        }

         public Task<List<Pet>> GetPets()
        {
            return database.Table<Pet>().ToListAsync();
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
