using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Para ter navegação de telas, a MainPage se torna uma tela de navegação.
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
