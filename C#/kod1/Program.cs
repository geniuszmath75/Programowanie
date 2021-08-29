using System;

namespace kod1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PROGRAM 11
            static bool l_pierwsza(int n)
            {
                if (n < 2)
                    return false;

                for (int i = 2; i * i <= n; i++)
                    if (n % i == 0)
                        return false;
                return true;
            }

            Console.Write("Podaj liczbę naturalną:");
            var x = int.Parse(Console.ReadLine());

            if (l_pierwsza(x))
                Console.WriteLine("Liczba " + x + " jest pierwsza");
            else
                Console.WriteLine("Liczba " + x + " nie jest pierwsza");
            */

            /*Program 9
            Console.Write("Podaj pierwszą liczbę:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Podaj trzecią liczbę:");
            int c = int.Parse(Console.ReadLine());

            if((a > b) && (a > c))
            {
                if(Math.Pow(a,2) == (Math.Pow(b, 2)+ Math.Pow(c, 2)))
                {
                    Console.WriteLine("Liczby stanowią trójkę pitagorejską.");
                }else
                {
                    Console.WriteLine("To nie jest trójka pitagorejska.");
                }
            }else if((b > a) && (b > c))
            {
                if (Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("Liczby stanowią trójkę pitagorejską.");
                }
                else
                {
                    Console.WriteLine("To nie jest trójka pitagorejska.");
                }
            }else
            {
                if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
                {
                    Console.WriteLine("Liczby stanowią trójkę pitagorejską.");
                }
                else
                {
                    Console.WriteLine("To nie jest trójka pitagorejska.");
                }
            }
            */

            /*Program 8
            Console.Write("Podaj rok:");
            var rok = int.Parse(Console.ReadLine());

            if(rok % 4 != 0)
            {
                Console.WriteLine("Rok " + rok + " nie jest przestępny");
            }else
            {
                if(rok % 100 != 0)
                {
                    Console.WriteLine("Rok " + rok + " jest przestępny");
                }else
                {
                    if(rok % 400 != 0)
                    {
                        Console.WriteLine("Rok " + rok + " nie jest przestępny");
                    }else
                    {
                        Console.WriteLine("Rok " + rok + " jest przestępny");
                    }
                }
            }
            */

            /*Program 7
            Console.WriteLine("Witaj w kalkulatorze!");
            Console.WriteLine("*********************");
            Console.WriteLine("Wybierz operator działania:");
            Console.WriteLine("+ - dodawanie");
            Console.WriteLine("- - odejmowanie");
            Console.WriteLine("* - mnożenie");
            Console.WriteLine("/ - dzielenie");
            var op = Console.ReadLine();

            Console.Write("Podaj pierwszy argument:");
            var a = float.Parse(Console.ReadLine());
            Console.Write("Podaj drugi argument:");
            var b = float.Parse(Console.ReadLine());

            var wynik = 1f;
            if(op == "+")
            {
                wynik = a + b;
                Console.WriteLine("Wynikiem dodawania " + a + " i " + b + " jest " + wynik);
            }
            else if(op == "-")
            {
                wynik = a - b;
                Console.WriteLine("Wynikiem odejmowania " + a + " i " + b + " jest " + wynik);
            }
            else if(op == "*")
            {
                wynik = a * b;
                Console.WriteLine("Wynikiem mnożenia " + a + " i " + b + " jest " + wynik);
            }
            else if(op == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Nie wolno dzielić przez zero!");
                }
                else
                {
                    wynik = a / b;
                    Console.WriteLine("Wynikiem dzielenia " + a + " i " + b + " jest " + wynik);
                }
            }
            */

            /*PROGRAM 6
            Console.Write("Podaj współczynnik a:");
            var a = float.Parse(Console.ReadLine());

            Console.Write("Podaj współczynnik b:");
            var b = float.Parse(Console.ReadLine());

            Console.Write("Podaj współczynnik c:");
            var c = float.Parse(Console.ReadLine());

            var delta = Math.Pow(b, 2) - 4 * a * c;
            var x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x0 = -b / (2 * a);

            if(delta > 0)
            {
                Console.Write("Równanie " + a + "x^2+" + b + "x+" + c + " ma dwa rozwiązania: x1=" + x1 + " i x2=" + x2);
            }
            else if(delta == 0)
            {
                Console.Write("Równanie " + a + "x^2+" + b + "x+" + c + " ma jedno rozwiązanie: x0=" + x0);
            }
            else
            {
                Console.Write("Równanie " + a + "x^2+" + b + "x+" + c + " nie ma rozwiązań");
            }
            */

            /*Program 5
            Console.WriteLine("Podaj wymiary walca:");
            var r = 1f;

            do
            {
                Console.Write("Podaj promień podstawy");
                string radius = Console.ReadLine();
                r = float.Parse(radius);
                if (r <= 0)
                {
                    Console.WriteLine("Promień musi być większy od zera\n");
                }
            } while (r <= 0);

            var h = 1f;

            do
            {
                Console.Write("Podaj wysokość walca:");
                string height = Console.ReadLine();
                h = float.Parse(height);
                if (h <= 0)
                {
                    Console.WriteLine("Wysokość musi być większa od zera\n");
                }
            } while (h <= 0);

            var pole = 2 * Math.PI * Math.Pow(r, 2) + 2 * Math.PI * r * h;
            var V = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("Pole walca wynosi " + pole + " a objętość " + V);
            */

            /*PROGRAM 4
            Console.Write("Podaj ile liczb chcesz wprowadzić:");
            int n = int.Parse(Console.ReadLine());
            int[] tab_n = new int[n];

            for(int i = 0;i<n;i++)
            {
                Console.Write("Podaj liczbę do posortowania:");
                int a = int.Parse(Console.ReadLine());
                tab_n[i] = a;
            }
            Array.Sort(tab_n);

            string wynik = "\nPosortowane liczby:" + tab_n[0] + " ";
            for (int j = 1; j < n; j++)
            {
                wynik += tab_n[j]+" ";
            }
            Console.WriteLine(wynik);
            */

            /*PROGRAM 3
            double liczba;
            Console.Write("Podaj liczbę:");
            liczba = Convert.ToDouble(Console.ReadLine());

            if (liczba >= 0)
                Console.Write("Pierwiastek z liczby " + liczba + " to "+ Math.Sqrt(liczba));
            else
                Console.Write("PIERWIASTEK KWADRATOWY Z LICZBY UJEMNEJ NIE ISTNIEJE.");
            */

            /*PROGRAM 2
            int wzrost;
            Console.Write("Podaj swój wzrost:");
            wzrost = Convert.ToInt32(Console.ReadLine());
            if(wzrost < 150)
                Console.Write("Niski");
            else if(wzrost > 150 && wzrost < 170)
                Console.Write("Średni");
            else if(wzrost > 170)
                Console.Write("Wysoki");
            else
                Console.Write("Czy na pewno podałeś poprawną liczbę?");
            */

            /*PROGRAM 1
            int a;
            Console.Write("Podaj liczbe całkowitą:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Liczba " + a +" jest parzysta.");
            else
                Console.WriteLine("Liczba " + a + " jest nieparzysta.");
            */
        }
    }
}
