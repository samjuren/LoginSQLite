using AppBanco.DbContext;

namespace AppBanco
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DataBaseHandler.Init();
            MainPage = new MainPage();
        }
    }
}
