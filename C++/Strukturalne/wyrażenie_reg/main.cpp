#include <iostream>
#include <regex>


using namespace std;

int main()
{
    regex wzorzec_pesel("^[1-9]{1}[0-9]{10}$");
    regex wzorzec_data ("^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.]((?:19|20)\d\d)$");
    regex wzorzec_kod("^[1-9]{1}[0-9]{1}\[-]{1}[1-9]{1}[0-9]{2}$");
    regex wzorzec_email("^[a-zA-Z0-9\.]{1,}[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{1,}$");
    regex wzorzec_ip("^[0-9]{3}[.][0-9]{3}[.][0-9]{1}[.][0-9]{1}$");

    smatch wyniki;

    string znaki_pesel;
    string znaki_data;
    string znaki_kod;
    string znaki_email;
    string znaki_ip;

    cout << "Podaj PESEL: ";
    getline(cin, znaki_pesel);

    cout << "Podaj aktualna date: ";
    getline(cin, znaki_data);

    cout << "Podaj kod pocztowy twojego miasta: ";
    getline(cin, znaki_kod);

    cout << "Podaj swoj email: ";
    getline(cin, znaki_email);

    cout << "Podaj adres IP: ";
    getline(cin, znaki_ip);

    if (regex_search(znaki_pesel, wyniki, wzorzec_pesel)) {
        cout << "\nTwoj PESEL to: " << znaki_pesel << "." << endl;
    }
    else{
        cout << "Niepoprawny format wprowadzonych danych. \n";
    }

    if (regex_search(znaki_data, wyniki, wzorzec_data)) {
        cout << "Aktualna data to: " << znaki_data << "." << endl;
    }
    else{
        cout << "Niepoprawny format wprowadzonych danych. \n";
    }

    if (regex_search(znaki_kod, wyniki, wzorzec_kod)) {
        cout << "Kod pocztowy twojego miasta to: " << znaki_kod << "." << endl;
    }
    else{
        cout << "Niepoprawny format wprowadzonych danych. \n";
    }

    if (regex_search(znaki_email, wyniki, wzorzec_email)) {
        cout << "Twoj email to: " << znaki_email << "." << endl;
    }
    else{
        cout << "Niepoprawny format wprowadzonych danych. \n";
    }

    if (regex_search(znaki_ip, wyniki, wzorzec_ip)) {
        cout << "Adres IP to: " << znaki_ip << "." << endl;
    }
    else{
        cout << "Niepoprawny format wprowadzonych danych. \n";
    }

return 0;
}
