#include <iostream>

using namespace std;

int main()
{
    int n;
    int stopnie[6] = {1, 2, 3, 4, 5, 6};
    cin >> n; // <--- wprowadzenie n
    int ** oceny = new int *[2]; // <--- deklaracja tablicy dwuwymiarowej
    oceny[0] = new int [n];
    oceny[1] = new int [n];

    int i = 0;
    do // <--- wprowadzenie ocen
    {
        cin >> oceny[0][i];
        i++;
    }while(i < n);

    int p = 0, k = 0, r = 0;
    for(int j = 0; j < oceny[0][k-1]; j++) // <--- pêtla sprawdza, kazda ocene ile razy wystêpuje
    {
        while(stopnie[p] == oceny[0][k])
            oceny[1][r] += 1;
            k++;
            p++;
            r++;
    }

    int t = 0;
    do
    {
        cout << oceny[1][t] << " ";
        t++;
    }while(t < n);

    delete [] oceny[0];
    delete [] oceny[1];
    delete [] oceny;

    return 0;
}
