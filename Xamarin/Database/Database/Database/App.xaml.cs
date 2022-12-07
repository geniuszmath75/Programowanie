using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Baza();
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
