#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

// Funkcja wype³niaj¹ca tablicê wylosowanymi liczbami
void wylosujLiczby(int tab[], int ilosc, int start, int stop)
{
    int i = 0;
    do
    {
        tab[i] = (rand() % 7) + start;
        i++;
    }while(i < ilosc);

}


// Funkcja wypisuj¹ca zawartoœæ tablicy
void wypiszLiczby(int tab[], int ilosc)
{
    int i = 0;
    do
    {
        cout << tab[i] << endl;
        i++;
    }while(i < ilosc);

}

// Funkcja obliczaj¹ca sumê iloœci liczb w tablicy
int obliczSume(int tab[], int ilosc)
{
    int suma = 0;
    int i = 0;
    do
    {
        suma += tab[i];
        i++;
    }while(i < 999);

    return suma;
}

int main()
{
    srand( time( NULL));
    int liczba[999];
    wylosujLiczby(liczba, 999, 4, 10);
    wypiszLiczby(liczba, 999);
    int iSuma = obliczSume(liczba, 999);
    cout << "Suma liczb wynosi: " << iSuma;

    return 0;
}

/*

// Program losuje 999 liczb ca³kowitych
// z zakresu od 4 do 10 w³¹cznie

int main()
{
    srand( time (NULL));
    int liczba[999];
    int suma = 0;

    int i = 0;
    do
    {
        liczba[i] = (rand() % 7) + 4; // wype³nianie tablicy
        cout << liczba[i] << endl; // wypisanie elementów
        suma += liczba[i]; // dodawanie elementów
        i++;
    }while(i < 999);

    cout << "Suma liczb wynosi: " << suma; // ostateczna suma

    return 0;
}
*/
