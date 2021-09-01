#include <iostream>
#include <math.h>
#include <windows.h>

using namespace std;

int main()
{

    int  a, b, i;
    float w;
    char znak;


    do{
    cout << "Witaj w kalkulatorze! \n";
    cout << "-------------------- \n";
    cout << "Oto dostepne dzialania: \n";

    cout << "1. Dodawanie \n";
    cout << "2. Odejmowanie \n";
    cout << "3. Mnozenie \n";
    cout << "4. Dzielenie \n";
    cout << "5. Pierwiastkowanie \n";

    wyborDzialanie:
    cout << "Wybierz dzialanie: ";
    cin >> i;
    if(i != 0 && i < 6){
        cout << "\nPodaj a: ";
        cin >> a;
    }
    else {
        cout << "Nie ma takiego dzialania! \n";
        goto wyborDzialanie;
    }

    wyborB:
    if(i < 5 ){
    cout << "Podaj b: ";
    cin >> b;
        if(b == 0){
            cout << "Nie mozna dzielic przez 0! \n";
            goto wyborB;
        }
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
    cout << "\nCzy chcesz zakonczyc ? (t/dowolny klawisz): ";
    cin >> znak;
    system("cls");
    }
    while (znak != 't');
    return 0;
}
