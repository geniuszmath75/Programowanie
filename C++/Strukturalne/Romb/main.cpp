#include <iostream>

using namespace std;

int main()
{
    int n, i, j, k;

    cin >> n;

    i=n;
    k=2;
    while(i--)
    {
        j=i+1;
        while(j--) cout << " ";

        j=k;
        while(j--) cout << "*";

        cout << endl;
        k+=2;
    }
    i=2*n;
    while(i--) cout << "*";
    cout << endl;

    i=n;
    k=2*n;
    while(i--)
    {
        j=n-i;
        while(j--) cout << " ";

        j=k;
        while(j--) cout << "*";

        cout << endl;
        k-=2;
    }
    return 0;


    /*int n, i, j, k;

    cin >> n;

    i=n;
    k=1;
    while(i--)
    {
        j=i+1;
        while(j--) cout << " ";

        j=k;
        while(j--) cout << "*";

        cout << endl;
        k+=2;
    }
    i=2*n+1;
    while(i--) cout << "*";
    cout << endl;

    i=n;
    k=2*n-1;
    while(i--)
    {
        j=n-i;
        while(j--) cout << " ";

        j=k;
        while(j--) cout << "*";

        cout << endl;
        k-=2;
    }
    return 0;*/
}
