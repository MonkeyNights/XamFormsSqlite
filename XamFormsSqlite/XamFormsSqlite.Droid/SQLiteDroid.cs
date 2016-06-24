using System.IO;
using SQLite.Net;
using XamFormsSqlite.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteAndroid))]
namespace XamFormsSqlite.Droid
{
    public class SQLiteAndroid : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "banco.db";
            var documentsPath = 
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return new SQLiteConnection(
                new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), path);
        }
    }
}