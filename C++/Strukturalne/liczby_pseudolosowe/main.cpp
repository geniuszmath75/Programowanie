#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    srand( time( NULL ));

    std::cout << "Postac: " <<((std::rand() % 30) + 1) << std::endl;

    int liczba = (std::rand() % 6 ) + 1;
    std::cout << "Umiejetnosc: " << liczba << std::endl;

    liczba =( std::rand() % 3 ) + 1;
    std::cout << "Starter: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Side Arm: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Close Range: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Automatic: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Long Range: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Heavy: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Explosive: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Defensive: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Utility: " << liczba << std::endl;

    liczba =( std::rand() % 5 ) + 1;
    std::cout << "Offensive: " << liczba << std::endl;

    return 0;
}
