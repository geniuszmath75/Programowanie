#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    string tekst;
    string napis;
    fstream plik;

    plik.open("Dane.txt", ios::app | ios::in | ios::out);
    if(plik.good() == true)
    {
        cout << "Uzyskano dostep do pliku!" << endl;
        cout << "Podaj dowolny tekst: "<< endl;
        getline(cin, tekst);
        plik << endl << tekst;
        getline(plik, tekst);

        plik.close();
    }else
        cout << "Dostep do pliku zostal zabroniony!";

    return 0;
}
