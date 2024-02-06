using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess
{
    public class AutoChessRepository
    {
        SQLiteConnection database;
        public AutoChessRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Sportsmans>();
        }
        public IEnumerable<Sportsmans> GetItems()
        {
            return database.Table<Sportsmans>().ToList();
        }
        public Sportsmans GetItem(int id)
        {
            return database.Get<Sportsmans>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Sportsmans>(id);
        }
        public int SaveItem(Sportsmans item)
        {
            if (item.ID != 0)
            {
                database.Update(item);
                return item.ID;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
