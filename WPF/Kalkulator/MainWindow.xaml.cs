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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Liczenie
    {
        public int a;
        public int b;
        public char dzialanie;

        public int Licz()
        {
            if (dzialanie == '+')
            {
                return a + b;
            }
            else if(dzialanie == '-')
            {
                return a - b;
            }
            else if (dzialanie == '*')
            {
                return a * b;
            }
            else if (dzialanie == '/')
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }
    }
    public partial class MainWindow : Window
    {

        Liczenie liczenie = new Liczenie();

        bool gdzieWpisac = true;
        bool czyWyczyscic = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cyfra1_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
                czyWyczyscic = false;
        }

        private void Cyfra2_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra3_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra4_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra5_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra6_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra7_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra8_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra9_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Cyfra0_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content = (sender as Button).Content.ToString();
            else
                poleWpisuj.Content += (sender as Button).Content.ToString();
            czyWyczyscic = false;
        }

        private void Przecinek_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscic)
                poleWpisuj.Content= "0,";
            else
                poleWpisuj.Content += ",";
                czyWyczyscic = false;
        }

        private void Dodawanie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.dzialanie = '+';
            gdzieWpisac = true;
            liczenie.a = liczenie.Licz();
            poleWpisuj.Content = liczenie.a.ToString();//wyświetlamy wynik
            czyWyczyscic = true;
        }

        private void Odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.dzialanie = '-';
            gdzieWpisac = true;
            liczenie.a = liczenie.Licz();
            poleWpisuj.Content = liczenie.a.ToString();//wyświetlamy wynik
            czyWyczyscic = true;
        }

        private void Mnożenie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.dzialanie = '*';
            gdzieWpisac = true;
            liczenie.a = liczenie.Licz();
            poleWpisuj.Content = liczenie.a.ToString();//wyświetlamy wynik
            czyWyczyscic = true;
        }

        private void Dzielenie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.dzialanie = '/';
            gdzieWpisac = true;
            liczenie.a = liczenie.Licz();
            poleWpisuj.Content = liczenie.a.ToString();//wyświetlamy wynik
            czyWyczyscic = true;
        }

        private void Wynik_Click(object sender, RoutedEventArgs e)
        {
            dzialanie.Content = liczenie.Licz();
        }
    }
}
