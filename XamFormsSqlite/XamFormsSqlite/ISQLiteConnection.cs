using SQLite.Net;

namespace XamFormsSqlite
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}
