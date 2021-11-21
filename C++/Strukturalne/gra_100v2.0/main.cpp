#include <iostream>
#include <cstdlib>
#include <ctime>
#include <cmath>

using namespace std;

int main()
{
    int number, liczba = 0, lowHigh, strzal, przedzial, proba = 0;
    cout << "Zakres z jakiego zgaduje liczbe to 1-";
    cin >> przedzial;
    strzal = round(przedzial/2);
    do
    {
        proba++;
        cout << "Czy szukana liczba to " << strzal << "?" << endl;
        cout << "Jesli tak - nacisnij 1. Jesli nie - nacisnij 0:";
        cin >> number;
        if(number == 1) cout << "Zgadlem liczbe za " << proba << " razem!";
        else
        {
            cout << "Jesli podana liczba jest za mala - wcisnij 0, Jesli za duza - wcisnij 1:";
            cin >> lowHigh;
            if(lowHigh == 0)
            {
                strzal += round(strzal - liczba) / 2;
            }
            else strzal -= round(strzal - liczba) / 2;
        }
    }while(number == 0);

    getchar();
    return 0;
}
