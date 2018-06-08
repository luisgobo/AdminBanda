using Android.OS;
using System;
using System.IO;
using SQLite;
using AdminBanda.Droid.Persistencia;
using AdminBanda.Persistencia;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace AdminBanda.Droid.Persistencia
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "AdminBandaSQL.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}