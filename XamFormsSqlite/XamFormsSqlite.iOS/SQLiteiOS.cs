using System.IO;
using SQLite.Net;
using XamFormsSqlite.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteiOS))]
namespace XamFormsSqlite.iOS
{
    public class SQLiteiOS : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "banco.db";
            var documentsPath = 
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return new SQLiteConnection(
                new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS(), path);
        }
    }
}