using SQLite;

namespace AdminBanda.Persistencia
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}