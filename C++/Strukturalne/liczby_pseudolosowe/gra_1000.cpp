#include <iostream>
#include <cstdlib>
#include <cstdio>
#include <ctime>

using namespace std;

int main()
{
    srand( time(NULL));
    int b = (std::rand() % 1000 ) + 1;
    int a;

    wybor:
    cout << "Podaj liczbe z zakresu 1-1000: ";
    cin >> a;

        if(a > b){
            cout << "Podana liczba jest za duza.\nSprobuj jeszcze raz.\n";
            goto wybor;
        }
        else
            if(a < b){
                cout << "Podana liczba jest za mala.\nSprobuj jeszcze raz.\n";
                goto wybor;
            }
            else
                 if(a == b){
                     cout << "Prawidlowa liczba!";
        }

    return 0;
}
