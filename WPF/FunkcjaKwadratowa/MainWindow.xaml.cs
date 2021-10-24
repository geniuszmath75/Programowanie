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

namespace FunkcjaKwadratowa
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

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(DanaA.Text);
            double b = double.Parse(DanaB.Text);
            double c = double.Parse(DanaC.Text);
            double delta;
            string wzor;
            string liczbaPierw;
            int pierw = 0;
            double x1;
            double x2;

            wzor = "f(x) = " + a + "x^2+" + b + "x+" + c;

            delta = Math.Pow(b, 2) - (4 * a * c);
            Math.Round(delta,2);

            if (a == 0)
            {
                liczbaPierw = "Parametr 'a' nie może być równy 0!";
                wynikDelta.Content = "Nie można obliczyć delty(funkcja nie jest kwadratowa)";
            }
            else
            {
                wynikDelta.Content = delta;

                if(b < 0)
                {
                    wzor = "f(x) = " + a + "x^2" + b + "x+" + c;
                }
                else if(c < 0)
                {
                    wzor = "f(x) = " + a + "x^2+" + b + "x" + c;
                }
                else if(b < 0 && c < 0)
                {
                    wzor = "f(x) = " + a + "x^2" + b + "x" + c;
                }

                if (delta < 0)
                {
                    pierw = 0;
                    liczbaPierw = "Funkcja nie posiada pierwiastków.";
                }
                else if (delta == 0)
                {
                    pierw = 1;
                    x1 = Math.Round(-b / (2 * a), 2);
                    liczbaPierw = "Funkcja posiada jeden pierwiastek:" + x1;
                }
                else
                {
                    pierw = 2;
                    x1 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
                    x2 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);
                    liczbaPierw = "Funkcja posiada dwa pierwiastki: x1 = " + x1 + " oraz x2 = " + x2 + ".";
                }
            }

            wynikWzor.Content = wzor;
            pierwiastkiWynik.Content = pierw;
            pierwiastkiWypisz.Content = liczbaPierw;
        }
    }
}
