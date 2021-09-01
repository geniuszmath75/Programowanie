using System;

class Fahrenheit{
    public static float oblicz(float f)
    {   
        return ((f - 32) * 5) / 9;
    }
}

class HelloWorld {
  static void Main() {
      
    //PROGRAM 2
    Console.WriteLine("Program zamienia temperaturę podaną w stopniach F na stopnie C");
    Console.Write("\nPodaj temperaturę w stopniach F:");
    float f = Convert.ToInt32(Console.ReadLine());
    float wynik = Fahrenheit.oblicz(f);
    Console.WriteLine(f+" stopni F = "+wynik +" stopni C");

 
    /*PROGRAM 1
    Console.Write("Podaj liczbę elementów tablicy: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[n];
    
    for(int i = 0;i < n;i++)
    {
        Console.Write("Podaj {0} element: ",i+1);
        tab[i] = Convert.ToInt32(Console.ReadLine());
    }
    //int[] tab2 = tab;
    
    //Array.Sort(tab2);
    
    int t = 0;
    int l = 0;
    float avg = 0;
    int suma_d = 0;
    
    for(int i = 0;i < n-1;i++)
    {
        
        if(tab[i] > tab[i+1])
        {
            if(l < tab[i+1])
            {
                t = i;
            }
            else
            {
                t = i;
                l = i+1;
            }
            
            
        }else
        {
            if(l < tab[i+1])
            {
                t = i+1;
            }
            else
            {
                t = i+1;
                l = i;
            }
        }
    }
    
    for(int i = 0;i < n;i++)
    {
        avg += tab[i];
    }
    avg /= n;
    
    for(int i = 0;i < n;i++)
    {
        if(tab[i] > 0)
            suma_d += 1;
    }
    Console.WriteLine("\nWartość i numer największego elementu wynosi: numer="+t+" wartość="+tab[t]);
    Console.WriteLine("Wartość i numer najmniejszego elementu wynosi: numer="+l+" wartość="+tab[l]);
    Console.WriteLine("Średnia wartości wszystkich elementów tablicy: {0}",avg);
    Console.WriteLine("Liczba dodatnich elementów tablicy: {0}",suma_d);*/
     
    /*ZADANIE 1
    Console.Write("Program wypisuje elementy 10-elementowej tablicy jednowymiarowej:\n");
    int[] dane = new int[10];
    
    for(int i = 0;i <= 9; i++)
    {
        dane[i] = i;
        Console.WriteLine("Dane["+i+"]:"+dane[i]);
    }*/
    
    /*ZADANIE 2
    Console.Write("Program wypisuje elementy 10-elementowej tablicy jednowymiarowej:\n");
    int[] dane = new int[10];

    int j = 0;    
    for(int i = 9;i >= 0; i--)
    {
        dane[i] = i;
        Console.WriteLine("Dane["+j+"]:"+dane[i]);
        j++;
    }*/
    
    /*ZADANIE 3
    int[] uczestnicy = {24, 30, 19, 20, 27};
    int suma = 0;
    
    for(int i=0; i<5;i++)
    {
        suma += uczestnicy[i];
    }
    
    Console.WriteLine("Suma wieku uczestników wycieczki:"+suma);
    Array.Sort(uczestnicy,0,5);
    Console.WriteLine("Najstarszy uczestnik wycieczki:"+uczestnicy[0]);
    Console.WriteLine("Najstarszy uczestnik wycieczki:"+uczestnicy[4]);*/
    
    /*ZADANIE 4
    Console.WriteLine("Ile imion chcesz wpisać?");
    int liczba = Convert.ToInt32(Console.ReadLine());
    string[] imiona = new string[liczba];

    for (int i = 0; i < liczba; i++)
    {
        Console.WriteLine("Podaj " + (i+1) + " imię");
        imiona[i] = Console.ReadLine();
    }

    for (int i = 0; i < liczba; i++)
    {
        Console.Write(imiona[i] + ",");
    }*/
    
    /*ZADANIE 5
    
    Console.WriteLine("Podaj liczbe elementow tablicy");
    int liczba = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[liczba];
    int suma = 0;

    for (int i = 0; i < liczba; i++)
    {
        Console.WriteLine("Podaj element [{0}] tablicy", i);
        tab[i] = Convert.ToInt32(Console.ReadLine());
    }

    suma = tab[0] + tab[1] + tab[2];

    Console.Write("Wybrane liczby to:"+tab[0]+","+tab[1]+","+tab[2]+", " );
    Console.WriteLine("Suma elementow tablicy to {0}", suma);*/
    
    /*ZADANIE 6
    
    int[,] macierz = new int[10,10];
    int suma = 0;
    Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej 10 x 10");
    
    for(int i = 0;i < 10;i++)
    {
        for(int j = 0;j < 10;j++)
        {
            if(i != j)
            {
                macierz[i,j] = 0;
            }
            else
            {
                macierz[i,j] = 1;
                suma += macierz[i,j];
            }
            Console.Write(macierz[i,j]+" ");
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("\nSuma wyróżnionych elementów w tablicy wynosi {0}",suma);*/
    
    /*ZADANIE 7
    int[,] tab = new int[10, 10];
    int suma1 = 0;
    int suma2 = 0;
    Console.WriteLine("Program wyswietla zawartosc tablicy dwuwymiarowej 10 x 10:\n");
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (j == 0)
            {
                tab[i, 0] = i;
                suma1 += tab[i,0];
            }
            else if (j == 1)
            {
                tab[i, 1] = i*i;
                suma2 += tab[i,1];
            }
            Console.Write(tab[i, j] + " ");
        }
        Console.WriteLine();
    }  
    
    Console.WriteLine("\nSuma liczb znajdujących się w pierwszej kolumnie = {0}",suma1);
    Console.WriteLine("\nSuma liczb znajdujących się w drugiej kolumnie = {0}",suma2);*/
    
    /*ZADANIE 8
    int[] tab = {1,2,3,4,5,6,7,8,9};
    
    Array.Reverse(tab); 
    
    for(int i = 0;i < 9; i++)
    {
        Console.WriteLine(tab[i]);
    }*/
    
    /*ZADANIE 9
    int[] tab = {4,2,6,23,1,3,7,0};
    Console.WriteLine("Posortowane elementy tablicy:");
    
    Array.Sort(tab);
    
    for(int i = 0;i < 8;i++)
    {
        Console.WriteLine(tab[i]);
    }*/
    
    /*ZADANIE 10
    string[] imiona = { "Ala", "Agata", "Ela", "Gienia", "Ola", "Ela", "Tola", "Ela"};
    
    Console.WriteLine("Pierwsze wystąpienie imienia 'Ala' jest na indeksie numer:"+Array.IndexOf(imiona,"Ala"));
    Console.WriteLine("Pierwsze wystąpienie imienia 'Ela' jest na indeksie numer:"+Array.IndexOf(imiona,"Ela"));
    Console.WriteLine("Pierwsze wystąpienie imienia 'Władysław' jest na indeksie numer:"+Array.IndexOf(imiona,"Władysław"));*/
    
    /*ZADANIE 11
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int[,] tab = new int[a+1,a+1];
    
    for(int i = 0;i < a+1;i++)
    {
        for(int j = 0;j < b+1;j++)
        {
            if(i == 0 || j == 0)
            {
                tab[i,0] = i;
                tab[0,j] = j;
            }
            else
            {
                tab[i,j] = i*j;
            }
            Console.Write(tab[i,j]+" ");
        }
        Console.WriteLine();
    }*/
  }
}
