#include <iostream>

using namespace std;

class numer
{
    int liczba;
    char nazwa[20];

public:
    numer(int 1, char *opis); //deklaracja konstruktora
    void funkcja(int a);
};

numer::numer(int i, char *opis)
{
    liczba=1;
    strcpy(nazwa,opis);
}

numer obiekt(100, "Tekst");
obiekt.funkcja(5);

int main()
{

}
