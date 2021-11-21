#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    srand( time(NULL));
    int b = (rand() % 100 ) + 1;
    int a;
    
    do
    {
        cout << "Podaj liczbe z zakresu 1-100: ";
        cin >> a;
        if(a == b)
        {
            cout << "Prawidlowa liczba!";
        }
        else
        {
            if(a > b)
            {
                cout << "Podana liczba jest za duza.\nSprobuj jeszcze raz.\n";
            }
            else
            {
                cout << "Podana liczba jest za mala.\nSprobuj jeszcze raz.\n";   
            }
        }
    }while(a != b);

    return 0;
}