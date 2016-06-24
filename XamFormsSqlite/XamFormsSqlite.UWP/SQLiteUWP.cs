using System.IO;
using SQLite.Net;
using XamFormsSqlite.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteUWP))]
namespace XamFormsSqlite.UWP
{
    public class SQLiteUWP : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "banco.db";
            var path = 
                Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, 
                sqliteFilename);
            return new SQLiteConnection(
                new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
        }
    }
}