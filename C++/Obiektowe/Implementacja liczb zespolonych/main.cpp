#include <iostream>
#include <math.h>

using namespace std;

class Zespolone{
    double Re, Im;
    
public:
    Zespolone(double r, double i)
    {
        Re = r;
        Im = i;
    }
    
    Zespolone() {
        Re = 0;
        Im = 0;
    }
    
    Zespolone operator +(Zespolone & z)
    {
        Zespolone wynik;
        wynik.Re = Re + z.Re;
        wynik.Im = Im + z.Im;
        return wynik;
    }
    
    Zespolone operator -(Zespolone & z)
    {
        Zespolone wynik;
        wynik.Re = Re - z.Re;
        wynik.Im = Im - z.Im;
        return wynik;
    }
    
    Zespolone operator *(Zespolone & z)
    {
        Zespolone wynik;
        wynik.Re = (Re * z.Re)-(Im * z.Im);
        wynik.Im = (Re * z.Im)+(Im * z.Re);
        return wynik;
    }
    
    Zespolone operator /(Zespolone & z)
    {
        double mianownik;
        Zespolone wynik;
        mianownik = (z.Re*z.Re)+(z.Im*z.Im);
        wynik.Re = ((Re * z.Re)+(Im * z.Im))/mianownik;
        wynik.Im = ((Im * z.Re)-(Re * z.Im))/mianownik;
        return wynik;
    }
    
    double modul(Zespolone z)
    {
        return sqrt(Re*Re+Im*Im);
    }
    
    friend ostream & operator <<(ostream & s, Zespolone & z);
};

ostream & operator <<(ostream & w, Zespolone & z)
{
    return w << z.Re << "+" << z.Im << "i";
}

int main()
{
    int Re, Im;
    int Re2, Im2;
    cout << "Podaj pierwszą liczbę zespoloną" << endl;
    cout << "Podaj część rzeczywistą:";
    cin >> Re;
    cout << "Podaj część zespoloną:";
    cin >> Im;
    cout << "Podaj drugą liczbę zespoloną" << endl;
    cout << "Podaj część rzeczywistą:";
    cin >> Re2;
    cout << "Podaj część zespoloną:";
    cin >> Im2;
    
    Zespolone z1(Re,Im);
    Zespolone z2(Re2,Im2);
    Zespolone z3 = (z1 + z2);
    Zespolone z4 = (z1 - z2);
    Zespolone z5 = (z1 * z2);
    Zespolone z6 = (z1 / z2);
    cout << "Pierwsza liczba: " << z1 << endl;
    cout << "Druga liczba:" << z2 << endl;
    cout << "Wynik dodawania:" << z3; 
    cout << "\nWynik odejmowania:" << z4;
    cout << "\nWynik mnożenia:" << z5;
    cout << "\nWynik dzielenia:" << z6;
    cout << "\nModuł pierwszej liczby:" << z1.modul(z1);
    cout << "\nModuł drugiej liczby:" << z2.modul(z2);

    return 0;
}
