using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Logowanie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void rejestruj(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private void loguj_Clicked(object sender, EventArgs e)
        {
            if(login.Text == "admin" && password.Text == "123456")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Błąd", "Login lub hasło są niepoprawne!\nSpróbuj jescze raz.", "OK");
            }
        }
    }
}