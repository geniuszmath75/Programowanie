#include <iostream>

using namespace std;

int wczytajLiczbe()
{
    int liczba;
    bool b;

    do // sprawdzanie czy liczba jest poprawna
    {
        cin.clear(); // czyszczenie flag b³êdu
        cin.sync(); // czyszczenie strumienia buforu
        cin >> liczba;
        cout << "Czy liczba jest poprawna?";
        cin.fail();
        b = cin.fail();
    } while(b == 1);

    return liczba;
}

int main()
{
    cout << "Podaj liczbe: ";
    int liczba = wczytajLiczbe();
    cout << "Podales liczbe: " << liczba <<endl;
    return 0;
}
