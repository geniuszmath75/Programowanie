#include <iostream>

int main()
{
    for ( int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 11; j++)
            if (i == j || j == 10-i+1 || i == 1 || i == 10 || j == 1 || j == 10)
                std::cout << "@ ";
            else
                std::cout << " ";
                std::cout << std::endl;
    }
    return 0;
}
