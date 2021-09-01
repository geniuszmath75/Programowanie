#include <iostream>

using namespace std;

int main()
{
    int op, x, y, w;

    cout << "1 Dodawanie " << endl;
    cout << "2 Odejmowanie " << endl;
    cout << "3 Mnozenie " << endl;
    cout << "4 Dzielenie " << endl;

    cout << "Wybierz program:";
    cin >> op;

    cout << "Wprowadz X: ";
    cin >> x;
    cout << "Wprowadz Y: ";
    cin >> y;

        switch (op){
      case 1:
         w = x + y;
         break;
      case 2:
        w = x - y;
        break;
      case 3:
        w = x*y;
        break;
      case 4:
        w = x / y;
        break;
    }

    cout << "Wynik = " << w << endl;

    return 0;

}
