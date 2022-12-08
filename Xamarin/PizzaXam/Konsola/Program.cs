namespace Pizza
{
    internal class Pizza
    {
        static void Main(string[] args)
        {
            int diameterPizza1, diameterPizza2;
            double pricePizza1, pricePizza2;
            double areaPizza1, areaPizza2;
            double howManyCm1, howManyCm2;

            Console.WriteLine("Program do przeliczania wyboru pizzy");
            Console.WriteLine();

            Console.Write("Podaj średnicę pierwszej pizzy: ");
            diameterPizza1 = int.Parse(Console.ReadLine());
            Console.Write("Podaj cenę pierwszej pizzy: ");
            pricePizza1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj średnicę drugiej pizzy: ");
            diameterPizza2 = int.Parse(Console.ReadLine());
            Console.Write("Podaj cenę drugiej pizzy: ");
            pricePizza2 = double.Parse(Console.ReadLine());
            
            areaPizza1 = areaOfPizza(diameterPizza1);
            areaPizza2 = areaOfPizza(diameterPizza2);

            howManyCm1 = howManyCm(areaPizza1, pricePizza1);
            howManyCm2 = howManyCm(areaPizza2, pricePizza2);

            Console.Write("Za 1 zł otrzymasz " + howManyCm1 + "cm2\n");
            Console.Write("Za 1 zł otrzymasz " + howManyCm2 + "cm2\n");

            if (howManyCm1 > howManyCm2)
                Console.WriteLine("Wybierz pizze nr 1");
            else
                Console.WriteLine("Wybierz pizze nr 2");

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
    }
}
