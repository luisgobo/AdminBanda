using AdminBanda.Entidades;
using PCLStorage;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBanda.Datos
{
    public class SqlHelper
    {
        static object locker = new object();
        SQLiteConnection database;
        public SqlHelper()
        {
            database = GetConnection();
            // create the tables
            database.CreateTable<Instrumento>();
        }
        public SQLite.SQLiteConnection GetConnection()
        {
            SQLiteConnection sqlitConnection;
            var sqliteFilename = "AdminBandaSQL.db3";
            IFolder folder = FileSystem.Current.LocalStorage;
            string path = PortablePath.Combine(folder.Path.ToString(), sqliteFilename);
            sqlitConnection = new SQLite.SQLiteConnection(path);
            return sqlitConnection;
        }

        public IEnumerable<Instrumento> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<Instrumento>() select i).ToList();
            }
        }

        public Instrumento GetItem(string codInstrumento)
        {
            lock (locker)
            {
                return database.Table<Instrumento>().Where(x => x.Codigo == codInstrumento).FirstOrDefault();                
            }
        }
        public Instrumento GetItem(string userName, string passWord)
        {
            lock (locker)
            {
                return database.Table<Instrumento>().FirstOrDefault(x => x.Codigo == passWord);
            }
        }
        public int SaveItem(Instrumento item)
        {
            lock (locker)
            {
                if (item.Codigo != "")
                {
                    //Update Item
                    database.Update(item);
                    return 1;
                    //return item.Codigo;
                }
                else
                {
                    //Insert item
                    return database.Insert(item);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Instrumento>(id);
            }
        }
    }
}
