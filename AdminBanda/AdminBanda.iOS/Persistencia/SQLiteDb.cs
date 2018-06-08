using AdminBanda.iOS.Persistencia;
using AdminBanda.Persistencia;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace AdminBanda.iOS.Persistencia
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "AdminBandaSQL.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}