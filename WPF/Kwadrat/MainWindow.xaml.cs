using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kwadrat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public String opcja;

        private void cBoxFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cBoxFigura.SelectedValue == itemKwadrat)
            {
                opcja = "Kwadrat";
                polaKwadrat.Visibility = Visibility.Visible;
                polaKolo.Visibility = Visibility.Hidden;
            }
            else
            {
                opcja = "Koło";

                polaKwadrat.Visibility = Visibility.Hidden;
                polaKolo.Visibility = Visibility.Visible;
            }
        }
        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(opcja == "Kwadrat")
            {
                double bok = 0;

                if (double.TryParse(txtBok.Text, out bok) && bok >= 0)
                {
                    txtPole.Text = Math.Pow(bok, 2.0).ToString();
                    txtObwod.Text = (4 * bok).ToString();
                    lblKomunikat.Content = String.Empty;
                }
                else
                {
                    lblKomunikat.Content = "Wpisano niepoprawne dane";
                }
            }
                
        }

        private void txtPromien_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(opcja == "Koło")
            {
                double r = 0;

                if (double.TryParse(txtPromien.Text, out r) && r >= 0)
                {
                    txtPole2.Text = (Math.PI * Math.Pow(r, 2)).ToString();
                    txtObwod2.Text = (2 * Math.PI * r).ToString();
                    lblKomunikat.Content = String.Empty;
                }
                else
                {
                    lblKomunikat.Content = "Wpisano niepoprawne dane";
                }
            }
        }
            
        //private void txtPromien_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    switch(opcja)
        //    {
        //        case "Koło":
        //            double r;

        //            if (double.TryParse(txtPromien.Text, out r) && r >= 0)
        //            {
        //                txtPole2.Text = (Math.PI * Math.Pow(r, 2)).ToString();
        //                txtObwod2.Text = (2 * Math.PI * r).ToString();
        //                lblKomunikat.Content = String.Empty;
        //            }
        //            else
        //            {
        //                lblKomunikat.Content = "Wpisz liczbę dodatnią";
        //            }
        //            break;
        //    }
        //}

        

        private void btnWyczysc_Click(object sender, RoutedEventArgs e)
        {
            txtBok.Text = String.Empty;
            txtPole.Text = String.Empty;
            txtObwod.Text = String.Empty;
            txtPromien.Text = String.Empty;
            txtPole2.Text = String.Empty;
            txtObwod2.Text = String.Empty;
            txtPrzybliz.Text = String.Empty;
            lblKomunikat.Content = "Wpisz dane";

            wynik.Content = opcja;
        }
        private void btnPrzybliz_Click(object sender, RoutedEventArgs e)
        {
            int liczba = int.Parse(txtPrzybliz.Text);
            double pole1 = 0;
            double pole2 = 0;
            double obwod = 0;
            double obwod2 = 0;
            if (double.TryParse(txtPole.Text, out pole1) && pole1 > 0)
            {
                txtPole.Text = Math.Round(pole1, liczba, MidpointRounding.AwayFromZero).ToString();
            }

            if (double.TryParse(txtPole2.Text, out pole2) && pole2 > 0)
            {
                txtPole2.Text = Math.Round(pole2, liczba, MidpointRounding.AwayFromZero).ToString();
            }

            if (double.TryParse(txtObwod.Text, out obwod) && obwod > 0)
            {
                txtObwod.Text = Math.Round(obwod, liczba, MidpointRounding.AwayFromZero).ToString();
            }

            if (double.TryParse(txtObwod2.Text, out obwod2) && obwod2 > 0)
            {
                txtObwod2.Text = Math.Round(obwod2, liczba, MidpointRounding.AwayFromZero).ToString();
            }
        }
    }
}
