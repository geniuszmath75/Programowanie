/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>

using namespace std;

class Klasa{
    private:
        int prywatna;
        int prywatnaMetoda(int x) const
        {
            return prywatna;
        }
        
    protected:
        int chroniona;
    
    private:
        static int prywatnaStatyczna;
        
    public:
        int publiczna;
        void publicznaMetoda(int n);

        static void publicznaMetodaStatycznaSet(int a);
        static int publicznaMetodaStatycznaGet();
  
    Klasa()
    { }
    
    Klasa(int b);
    
    ~Klasa()
    {
        cout << "\nPapa!" << endl;
    }
    
    friend class Zaprzyjazniona;
    friend void zaprzyjaznionaFunkcja(Klasa &);
};

class Zaprzyjazniona{
    public:
        void zaprzyjaznionaMetoda(Klasa & k)
        {
            k.prywatna = 0;
        }
};

class Dziedziczaca final
    : public Klasa
{
    public:
        Dziedziczaca(int c)
            : Klasa( c )// wywołujemy konstruktor klasy bazowej
        { }
};

void zaprzyjaznionaFunkcja(Klasa & k)
{
    k.prywatna = 0;
}

void Klasa::publicznaMetoda(int n)
{
    publiczna = n;
}

int Klasa::prywatnaStatyczna;

void Klasa::publicznaMetodaStatycznaSet(int a)
{
    prywatnaStatyczna = a;
}

int Klasa::publicznaMetodaStatycznaGet()
{
    return prywatnaStatyczna;
}

Klasa::Klasa(int b)
{ }

int main()
{
    Klasa obiekt1;
    Zaprzyjazniona obiekt2;
    Dziedziczaca obiekt3(1);
    
    cout << "1. Metoda prywatna obiektu1 klasy Klasa(brak dostępu)" << endl;
    //obiekt1.prywatnaMetoda();
    cout << "2. Metoda publiczna obiektu1 klasy Klasa(dostępna)" << endl;
    obiekt1.publicznaMetoda( 10 );
    cout << "3. Metoda statyczna publiczna klasy Klasa ustala wartosc skladowej" << endl;
    obiekt1.publicznaMetodaStatycznaSet( 16 );
    cout << "4. Metoda statyczna publiczna klasy Klasa zwraca wartosc skladowej:";
    cout << obiekt1.publicznaMetodaStatycznaGet() << endl;
    
    cout << "5. Zaprzyjaźniona metoda publiczna klasy Zaprzyjazniona ustala wartosc skladowej z klasy Klasa:";
    obiekt2.zaprzyjaznionaMetoda( obiekt1 );
    cout << "\n6. Zaprzyjaźniona funkcja klasy Zaprzyjazniona ustala wartosc skladowej z klasy Klasa:";
    zaprzyjaznionaFunkcja( obiekt1 );
    
    return 0;
}
    






