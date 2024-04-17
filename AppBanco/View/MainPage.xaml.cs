using AppBanco.DbContext;
using AppBanco.Model;

namespace AppBanco
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            DataBaseHandler.Insert(new CreateLogin
            {
                Email = ""
            });

           var all = DataBaseHandler.GetAll<CreateLogin>();
        }
    }

}
