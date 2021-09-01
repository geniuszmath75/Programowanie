#include <iostream>
using namespace std;

int main()
{
    int op, pop, w;
    char a, b, c, d;

    cout << "Wartosc wyrazenia 5-2*(2+3) rowna sie: " << endl;
    cout << "A: 4" << endl;
    cout << "B: 9" << endl;
    cout << "C: 15" << endl;
    cout << "D: -5" << endl;

    cout << "Twoja odpowiedz:";
    cin >> op;

    switch(op){
      case 1:
           w = a;
       break;
      case 2:
          w = b;
        break;
      case 3:
          w = c;
        break;
      case 4:
          w = d;
        break;
    }
    cout << "Poprawna odpowiedz to: D";
    return 0;
}
