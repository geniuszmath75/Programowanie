#Wyświetlanie elementów listy za pomocą pętli
filmy = ["Noc żywych trupów",
         "Ekipa",
         "Rodzina Soprano",
         "Pamiętniki wampirów",
         ];

for pokaz_filmy in filmy:
    print(pokaz_filmy);

print("\n");

#Wyświetlanie liczb z zakresu 25-50
for i in range(25,51):
    print(i);

print("\n");

#Wyświetlanie elementów listy wraz z indeksami
i = 0;
for tytul in filmy:
    tytul = filmy[i];
    filmy[i] = tytul;
    print(i);
    print(tytul);
    i += 1;

print("\n");

#Pętla nieskończona
liczby = [4, 27, 17, 53, 100,8, 76, 45, 61, 12,];

while True:
    print("Wpisz q, aby zakończyć")
    pytanie = input("Podaj liczbę z zakresu 1 - 100:");
    if pytanie == "q":
        break;

    pytanie = int(pytanie);
    
    if pytanie in liczby:
        print("Zgadłeś!");
    else:
        print("Spróbuj ponownie!");
        
print("\n");

#Program 5
lista_1 = [8, 19, 148, 4];
lista_2 = [9, 1, 33, 83];
lista_3 = [];

for i in lista_1:
    for j in lista_2:
        x = i*j;
        lista_3.append(x);

print(lista_3);
