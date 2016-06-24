using XamFormsSqlite.ViewModels;

namespace XamFormsSqlite
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
