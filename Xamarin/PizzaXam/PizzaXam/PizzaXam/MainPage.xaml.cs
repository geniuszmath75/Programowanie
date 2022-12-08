using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PizzaXam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void oblicz_Clicked(object sender, EventArgs e)
        {
            int diameterPizza1 = int.Parse(diameter1.Text);
            int diameterPizza2 = int.Parse(diameter2.Text);
            double pricePizza1 = double.Parse(price1.Text);
            double pricePizza2 = double.Parse(price2.Text);
            double areaPizza1, areaPizza2;
            double howManyCm1, howManyCm2;

            areaPizza1 = areaOfPizza(diameterPizza1);
            areaPizza2 = areaOfPizza(diameterPizza2);

            howManyCm1 = howManyCm(areaPizza1, pricePizza1);
            howManyCm2 = howManyCm(areaPizza2, pricePizza2);

            wynik.Text += howManyCm1 + "cm2";
            wynik2.Text += howManyCm2 + "cm2";

            if (howManyCm1 > howManyCm2)
                wynik3.Text = "Wybierz pizze nr 1";
            else
                wynik3.Text = "Wybierz pizze nr 2";
        }

        static double areaOfPizza(int diameterPizza)
        {
            double areaPizza = (Math.PI * Math.Pow(diameterPizza / 2, 2));
            return areaPizza;
        }

        static double howManyCm(double areaPizza, double pricePizza)
        {
            double cm = areaPizza / pricePizza;
            return Math.Round(cm, 2);
        }

        private void reset_Clicked(object sender, EventArgs e)
        {
            diameter1.Text = "";
            diameter2.Text = "";
            price1.Text = "";
            price2.Text = "";
            wynik.Text = "";
            wynik2.Text = "";
            wynik3.Text = "";
        }
    }
}
