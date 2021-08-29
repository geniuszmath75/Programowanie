#Odczyt pliku
with open("plik.txt", "r") as f:
    print(f.read());

#Zapis do pliku
pytanie = input("Jaki jest dzisiaj dzień tygodnia?");

with open("plik2.txt", "w") as f:
    f.write(pytanie );

#Tworzenie pliku CSV
import csv;

lista = [
        ["Top Gun", "Ocean's Eleven", "Raport mniejszości"],
        ["Titanic", "Ostatni Jedi", "Incepcja"],
        ["Pulp Fiction", "Człowiek w ogniu", "Seksmisja"]
    ];

with open("plik.csv", "w", newline='') as f:
    write = csv.writer(f, delimiter=",")
    write.writerow(lista[0]);
    write.writerow(lista[1]);
    write.writerow(lista[2]);
