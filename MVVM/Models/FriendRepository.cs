using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.Models
{
    public class FriendRepository
    {
        SQLiteConnection database;
        public FriendRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<DBFriend>();
        }
        public IEnumerable<DBFriend> GetItems() 
        {
            return database.Table<DBFriend>().ToList();
        }
        public DBFriend GetItem(int id)
        {
            return database.Get<DBFriend>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<DBFriend>(id);
        }
        public int SaveItem(DBFriend item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }           
        }
    }
}
