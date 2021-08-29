#Wyświetlanie znaków łańcucha
string = "Camus";
print(string[0]);
print(string[1]);
print(string[2]);
print(string[3]);
print(string[4]);
print("\n");

#Program 1
łańcuch1 = input("Podaj jakiś gatunek literacki: ");
łańcuch2 = input("Podaj imię w dopełniaczu: ");

zdanie = "Wczoraj napisałem i wysłałem do.";
zdanie = "Wczoraj napisałem {} i wysłałem do {}.\n".format(łańcuch1, łańcuch2); 
print(zdanie);

#Poprawa zdania
print("aldous Huxley rodził się w 1894 roku.\n".capitalize());

#Zmiana stringa w listę
print("Gdzie teraz? Kto teraz? Kiedy, teraz?".split("? "));
print("\n");

#Łączenie elementów listy w stringa
lista = [
        "Zwinny",
        "lis",
        "przeskoczył",
        "nad",
        "leniwym",
        "psem",
        "."
];

kropka = lista.pop();
string1 = " ".join(lista);
string2 = string1 + kropka;
print(string2);
print("\n");

#Zastąpienie litery w stringu
string = "W czasie suszy szosa sucha.";
new_string = string.replace("s" ,"$");
print(new_string);
print("\n");

#Zwracanie indeksu
słowo = "Hemingway";
print(słowo.index("m"));

#Użycie cudzysłowa w cudzysłowie
dialog = """
\"Co tam słychać?\" - spytał Tomek.
\"A jakoś leci\" - odpowiedziała Julka.
        """;
print(dialog);
print("\n");

#Konkatenacja i powielanie stringa
sposób1 = "trzy "+"trzy "+"trzy";
sposób2 = "trzy " * 3;

print(sposób1);
print(sposób2);
print("\n");

#Wycinek stringa
długi_string = """Długo na szturm i szaniec poglądał w milczeniu.
Na koniec rzekł: 'Stracona'
               """
print(długi_string[:47]);
