#include <iostream>
#include <ctime>

using namespace std;

int losuj()
{
    srand( time( NULL ) );
    int a = (rand() % 10) + 50;

    return a;
}

int main()
{
    cout << "Maszyna losujaca z zakresu 50-60"<<endl;
    cout << "Wylosowane liczba to: " << losuj() <<endl;

    return 0;
}
