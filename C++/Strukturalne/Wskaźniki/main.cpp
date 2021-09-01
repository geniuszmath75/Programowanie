#include <iostream>

using namespace std;

int main()
{
    int a=5, b=10, *wsk, tab[10];
    wsk=&a;
    
    cout << "Zmienna a="<< a << " zmienna b="<< b <<" oraz zmienna pokazywana przez wskaźnik:"<<*wsk<<" adres komórki:"<<wsk;
    
    *wsk=100;
    cout << "\n\nZmienna a="<< a << " zmienna b="<< b <<" oraz zmienna pokazywana przez wskaźnik:"<<*wsk<<" adres komórki:"<<wsk;

    wsk=&b;
    cout << "\n\nZmienna a="<< a << " zmienna b="<< b <<" oraz zmienna pokazywana przez wskaźnik:"<<*wsk<<" adres komórki:"<<wsk;
   
    cout << "\n*************************************************************************************************\n";
    
    for(int i=0;i<10;i++)
    {
        tab[i]=i+100;
        wsk=tab;
    }
    for(int i=0;i<10;i++)
    {
        cout << *(wsk++)<< endl;
    }
    
    return 0;
}

