#include <iostream>
#include <math.h>

using namespace std;

int main()
{

    int w, a, b, i;

    cout << "Witaj w kalkulatorze! \n";
    cout << "-------------------- \n";
    cout << "Oto dostepne dzialania: \n";

    cout << "1. Dodawanie \n";
    cout << "2. Odejmowanie \n";
    cout << "3. Mnozenie \n";
    cout << "4. Dzielenie \n";
    cout << "5. Pierwiastkowanie \n";

    cout << "Wybierz dzialanie: ";
    cin >> i;

    cout << "\nPodaj a: ";
    cin >> a;
    if(i < 5){
    cout << "Podaj b: ";
    cin >> b;
    }

    if(i == 1){
        w = a+ b;
        cout << "Wynik dodawania jest rowny: " << w;
    }
    else
    if(i == 2){
        w = a - b;
        cout << "Wynik odejmowania jest rowny: " << w;
    }
    else
    if(i == 3){
        w = a * b;
        cout << "Wynik mnozenia jest rowny: " << w;
    }
    else
    if(i == 4){
        w = a / b;
        cout << "Wynik dzielenia jest rowny: " << w;
    }
    else
    if(i == 5){
        w = sqrt(a);
        cout << "Wynik pierwiastkowania jest rowny: " << w;
    }

    return 0;
}
