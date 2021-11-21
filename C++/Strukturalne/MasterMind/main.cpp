#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

void game()
{

}

int main()
{
    cout << "Witaj w grze Master Mind!\n";
    cout << "-------------------------\n";

    while(true)
    {
        int option;
        cout << "1. Rozpocznij grê\n";
        cout << "2. Instrukcja gry\n";
        cout << "3. Zakoñcz grê\n";
        cout << "Co chcesz zrobiæ?";
        cin >> option;

        switch(option)
        {
        case 1:
            game();
            break;
        case 2:

        }
    }
}
