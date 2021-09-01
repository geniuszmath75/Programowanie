using System;

public class Sprzedaz {
    static string nazwa;
    static int ilosc;
    static decimal cena;
    
    public Sprzedaz(string p, int a, decimal sP)
    {
        nazwa = p;
        ilosc = a;
        cena = sP;
    }
    
    public void wypisz()
    {
        Console.WriteLine("Nazwa produktu:{0}, ilosc:{1}, cena:{2} ",nazwa,ilosc,cena);
    }
}

public class Zamowienia{
    static string data_real;
    static string nazwa_klienta;
    
    public Zamowienia(string data, string nazwa_kli)
    {
        data_real = data;
        nazwa_klienta = nazwa_kli;
    }
    
    public void wypisz2()
    {
        Console.WriteLine("Data realizacji:{0}, Nazwa klienta:{1}",data_real,nazwa_klienta);
    }
}

class HelloWorld {
  static void Main(string[] args) {
    Sprzedaz ob = new Sprzedaz("Krzesło", 5, 500);
    ob.wypisz();
    
    Zamowienia ob2 = new Zamowienia("21.06.2020", "Jan Kowalski");
    ob2.wypisz2();
  }
}
