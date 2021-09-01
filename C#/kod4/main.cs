using System;

public class Osoba {
    static string nazwisko;
    static string imie;
    static string ulica;
    static string kod;
    static string miasto;
    
    public void wczytaj(string n, string i, string u, string k, string m) {       
        nazwisko = n;
        imie = i;
        ulica = u;
        kod = k;
        miasto = m;
        
        Console.WriteLine("Podaj nazwisko:");
        nazwisko = Console.ReadLine();
        Console.WriteLine("Podaj imię:");
        imie = Console.ReadLine();
        Console.WriteLine("Podaj ulicę:");
        ulica = Console.ReadLine();
        Console.WriteLine("Podaj kod:");
        kod = Console.ReadLine();
        Console.WriteLine("Podaj miasto:");
        miasto = Console.ReadLine();
    }
    
    public void wypisz() {
        Console.WriteLine("Nazwisko:{0}",nazwisko);
        Console.WriteLine("Imię:{0}",imie);
        Console.WriteLine("Ulica:{0}",ulica);
        Console.WriteLine("Kod:{0}",kod);
        Console.WriteLine("Miasto:{0}",miasto);
    }
}

class HelloWorld {
  static void Main(string[] args) {
    Console.WriteLine("Wprowadzamy dane:");
    Console.WriteLine("*************************");
    Osoba ob1 = new Osoba();
    Osoba ob2 = new Osoba();
    ob1.wczytaj("Kowalski", "Jan", "Kolorowa 4", "35-500", "Katowice");
    ob2.wypisz();
    
  }
}
