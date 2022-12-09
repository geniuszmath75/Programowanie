using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace Logowanie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void walidacja_Clicked(object sender, EventArgs e)
        {
            string Email = email.Text;
            string Password = password1.Text;
            string Password2 = password2.Text;
            string Firstname = firstname.Text;
            string Lastname = lastname.Text;
            string PESEL = pesel.Text;
            string PosterCode = posterCode.Text;

            string regExp1 = @"^(?:[a-zA-Z0-9]+(?:\.[./a-zA-Z0-9]+)*)@[a-zA-Z0-9]{1,}\.[a-zA-Z]{2,3}$";
            string regExp2 = @"^[A-Za-z0-9]{8,}$";
            string regExp3 = @"^[A-Z]{1}[a-z]{2,}$";
            string regExp4 = @"^[0-9]{11}$";
            string regExp5 = @"^[0-9]{2}-[0-9]{3}$";

            if(String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(Password2) || String.IsNullOrEmpty(Firstname) || String.IsNullOrEmpty(Lastname) || String.IsNullOrEmpty(PESEL) || String.IsNullOrEmpty(PosterCode))
            {
                correct.Text = "Uzupełnij wszystkie pola!";
                correct.TextColor = Color.Red;
            }
            else
            {
                if (Regex.IsMatch(Email, regExp1) && Regex.IsMatch(Password, regExp2) && Password == Password2 && Regex.IsMatch(Firstname, regExp3) && Regex.IsMatch(Lastname, regExp3) && Regex.IsMatch(PESEL, regExp4) && Regex.IsMatch(PosterCode, regExp5))
                {
                    DisplayAlert("Rejestracja konta", "Dane zostały wpisane poprawnie.", "OK");

                    errorE.Text = "";
                    errorH.Text = "";
                    errorH2.Text = "";
                    errorI.Text = "";
                    errorN.Text = "";
                    errorP.Text = "";
                    errorPC.Text = "";

                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    correct.Text = "";
                    if (!Regex.IsMatch(Email, regExp1))
                        errorE.Text = "Niepoprawny email!";
                    else
                        errorE.Text = "";

                    if (!Regex.IsMatch(Password, regExp2))
                        errorH.Text = "Niepoprawne lub za krótkie hasło!";
                    else
                        errorH.Text = "";

                    if (Password2 != Password)
                        errorH2.Text = "Hasła muszą być takie same.";
                    else
                        errorH2.Text = "";

                    if (!Regex.IsMatch(Firstname, regExp3))
                        errorI.Text = "Niepoprawne imię!";
                    else
                        errorI.Text = "";

                    if (!Regex.IsMatch(Lastname, regExp3))
                        errorN.Text = "Niepoprawne nazwisko!";
                    else
                        errorN.Text = "";

                    if (!Regex.IsMatch(PESEL, regExp4))
                        errorP.Text = "Niepoprawny PESEL!";
                    else
                        errorP.Text = "";

                    if (!Regex.IsMatch(PosterCode, regExp5))
                        errorPC.Text = "Niepoprawny kod pocztowy!";
                    else
                        errorPC.Text = "";
                }
            }
        }
    }
}