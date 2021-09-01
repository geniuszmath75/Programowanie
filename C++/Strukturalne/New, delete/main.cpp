#include <iostream>

using namespace std;

int main()
{
    int * tablica = nullptr, rozmiarTab = 1, indeks = 0, iloscLiczb = 0, liczba = 0;
    cout << "Podawaj liczby, 0 konczy wczytywanie.\n";
   
    while( true )
    {
        cin >> liczba;
       
        if( liczba == 0 )
             break;
        else
            iloscLiczb++;
            
        if(iloscLiczb >= rozmiarTab)
        {
            rozmiarTab*=2;
       
            int * nowa = new int[ rozmiarTab];
       
            for( int i = 0; i < indeks; ++i )
                nowa[i] = tablica[i];
       
            delete[] tablica;
       
            tablica = nowa;
        }
        
        tablica[indeks] = liczba;
        indeks++;
    }
   
    cout << "Te same liczby, ale odwrotnie!\n";
   
    for( int i = iloscLiczb - 1; i >= 0; --i )
         std::cout << tablica[ i ] << ' ';
   
    cout << "\nRozmiar tablicy:  " << rozmiarTab << endl;
}

