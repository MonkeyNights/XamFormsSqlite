using XamFormsSqlite.Models;

namespace XamFormsSqlite.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            var usuario = GetUser();
            if (usuario == null)
            {
                App.SqliteConnection.Insert(new Usuario
                {
                    Nome = "aew",
                    Contador = 1
                });
            }
            else
            {
                usuario.Contador++;
                App.SqliteConnection.Update(usuario);
            }

            usuario = GetUser();

            Nome = usuario.Nome + "(" + usuario.Contador + ")";
        }

        private static Usuario GetUser()
        {
            return App.SqliteConnection.Table<Usuario>().FirstOrDefault();
        }
    }
}
