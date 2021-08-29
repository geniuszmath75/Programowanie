#Funkcja zwracająca liczbę podniesioną do kwadratu
def int_2():
    """
    Zwraca x**2.
    :param x: int.
    :return: int kwadrat x.
    """
    x = input("Podaj liczbę: ");
    x = int(x);
    return x**2;

print(int_2());

#Wyświetlanie stringa
def pokaz_string():
    """
    Zwraca wprowadzony łańcuch znaków.
    """
    wyraz = input("Podaj łańcuch znaków: ");
    print(wyraz);

pokaz_string();

#Trzy parametry wymagane, dwa opcjonalne
def f1(x,y,z, a=10,b=4.5):
    """
    Zwraca x*a, y*b i z*z.
    :param x: int.
    :param y: int.
    :param z: int.
    :param a: 10 int.
    :param b: 4.5 float.
    """
    wynik1 = x*a;
    wynik2 = y*b;
    wynik2 = float(wynik2);
    wynik3 = z*z;
    print(wynik1);
    print(wynik2);
    print(wynik3);

f1(4,7,11);
f1(4,7,11,5);

#Dwie funkcje
def fun1():
    """
    Zwraca x/2.
    : return: float iloraz x i 2.
    """
    x = input("Podaj liczbę całkowitą: ");
    x = int(x);
    return x/2;

y = fun1();

def fun2():
    """
    Zwraca y*4.
    :return: float iloczyn y i 4. 
    """
    return y*4;

print(fun2());

#Funkcja konwertująca
def konwert():
    """
    Zwraca float, jeśli łańcuch znaków jest poprawny.
    """
    try:
        wyraz = input("""Podaj łańcuch znaków do przekonwertowania na liczbę
        zmiennoprzecinkową: """);
        wyraz = float(wyraz);
        print(wyraz);
    except ValueError:
        print("Nieprawidłowe dane wejściowe!");

konwert();

