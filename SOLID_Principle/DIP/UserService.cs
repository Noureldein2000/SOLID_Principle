using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.DIP
{
    internal class UserService
    {
        //------------------------- Violating DIP ------------------------------------
        //private MySQLDatabase _database;

        //public UserService()
        //{
        //    _database = new MySQLDatabase(); // ❌ Tightly coupled to MySQL
        //}

        //UserService directly depends on MySQLDatabase, making it difficult to switch to another database (e.g., MongoDB, SQL Server).
        //If we need to change from MySQL to another database, we must modify UserService, violating the Open-Closed Principle (OCP).


        //------------------------- Applying DIP (Better Approach) ------------------------------------
        private readonly IDatabase _database;

        public UserService(IDatabase database) // Inject dependency
        {
            _database = database;
        }

        public void RegisterUser(string username)
        {
            _database.SaveData(username);
            Console.WriteLine($"User {username} registered.\n");
        }

        //Loose coupling – UserService no longer depends on MySQLDatabase but on IDatabase.
        //Easily switch databases – We can swap MySQLDatabase with MongoDBDatabase without modifying UserService.
        //Better testability 
    }
}
