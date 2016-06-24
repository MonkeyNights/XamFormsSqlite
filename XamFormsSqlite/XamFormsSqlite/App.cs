using SQLite.Net;
using Xamarin.Forms;
using XamFormsSqlite.Models;

namespace XamFormsSqlite
{
    public class App : Application
    {
        private static SQLiteConnection _sqliteConnection;

        public static SQLiteConnection SqliteConnection => _sqliteConnection;

        public App()
        {
            _sqliteConnection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            _sqliteConnection.CreateTable<Usuario>();

            // The root page of your application
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
