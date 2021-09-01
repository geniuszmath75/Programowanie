#include <iostream>
#include <string>
#include <ctime>
#include <cstdlib>
#include <cstdio>

using namespace std;

string Zaszyfrowanie(string);
string Odszyfrowanie(string);

int main()
{

    int a;
    string wyrazenie;
    string slowo;

    cout << "Co chcesz zrobic? \n";
    cout << "1. Zaszyfrowac wyrazenie \n";
    cout << "2. Odszyfrowac wyrazenie \n" ;
    cout << "Wprowadz cyfre: ";
    cin >> a;

    switch(a)
    {
    case 1:
        cout << "Podaj wyrazenie do zaszyfrowania: ";
        cin >> wyrazenie;
        cout << "\nZaszyfrowane wyrazenie to:" << Zaszyfrowanie(wyrazenie);
        break;
    case 2:
        cout << "Podaj wyrazenie do odszyfrowania: ";
        cin >> slowo;
        cout << "\nOdszyfrowane wyrazenie to:" << Odszyfrowanie(slowo);
        break;
    }


    getchar();
    return 0;

}

string Zaszyfrowanie(string wyrazenie) {

     srand(time(NULL));
     int t;
     int ile = (std::rand() % 6 ) + 1;

     cout << "Wylosowana liczba przesuniecia to: " << ile << "\n";

     for(int i = 0; i < wyrazenie.length(); i++)
     {
        t = wyrazenie[i] + ile;

        if(t < 65)
            wyrazenie[i] += (26 + ile);
        else if(t > 90)
            wyrazenie[i] -= (26 - ile);
        else
            wyrazenie[i] += ile;
     }
     return wyrazenie;
}

string Odszyfrowanie(string slowo) {

     srand(time(NULL));
     int t;
     int ile = (std::rand() % 6 ) + 1;

     cout << "Wylosowana liczba przesuniecia to: " << ile << "\n";

     for(int i = 0; i < slowo.length(); i++)
     {
        t = slowo[i] - ile;

        if(t < 65)
            slowo[i] += (26 - ile);
        else if(t > 90)
            slowo[i] -= (26 + ile);
        else
            slowo[i] -= ile;
     }
     return slowo;

}
