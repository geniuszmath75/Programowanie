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
        cout << "1. Rozpocznij gr�\n";
        cout << "2. Instrukcja gry\n";
        cout << "3. Zako�cz gr�\n";
        cout << "Co chcesz zrobi�?";
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
