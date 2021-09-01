#include <iostream>

using namespace std;

int main(int argc, char* argv[])
{
    cout << "\nLiczba argumentow linii komend to:";
    cout << argc << "\n\n";
    
    for(int i=0;i<argc;i++)
    {
        cout << "Slowo " << i << " to: \n ";
        cout << argv[i] << "\n";
    }

    return 0;
}
