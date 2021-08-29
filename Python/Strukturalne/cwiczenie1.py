#Wyświetl trzy różne łańcuchy
print("Cześć!");
print("Siema!");
print("Elo!\n");

#Komunikat 1
x = 15;
print(x);

if x < 10:
    print("Liczba mniejsza od 10.");
else:
    print("Liczba wieksza lub równa 10.\n");

#Komunikat 2
x = 30;
print(x);

if x <= 10:
    print("Liczba mniejsza lub równa 10.\n");
elif x > 10 and x <= 25:
    print("Liczba większa od 10, ale mniejsza lub równa 25.\n");
else:
    print("Liczba większa od 25.\n");

#Reszta z dzielenia
x = 14;
y = 4;
z = x%y;

print("Reszta z dzielenia 14 przez 4 wynosi:");
print(z);

#Iloraz
x = 20;
y = 5;
z = x/y;

print("\nIloraz działania 20 podzielone przez 5 wynosi:");
print(z);
print("\n");

#Komunikat 3
age = -10;
print(age);

if age >= 0 and age < 18:
    print("Jesteś niepełnoletni!\n");
elif age >= 18:
    print("Jesteś pełnoletni!\n")
else:
    print("Nie można mieć ujemnej liczby lat!\n");
