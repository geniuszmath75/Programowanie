#Ulubieni muzycy
muzycy = ["Alan Walker", "Taco Hemingway", "TACONAFIDE", "Paluch", "Ava Max"];
print(muzycy);
print("\n");

#Współrzędne miejsc
miejsca = [
        (49.6493, 20.5422),
        (49.7149, 20.4230),
        (49.6103, 20.7159),
        (50.0469, 19.9971),
        (52.4006, 16.9197),
];
print(miejsca);
print("\n");

#Info o mnie
Ja = {
        "1": "Wzrost:176",
        "2": "Wiek:18",
        "3": "Płeć:M",
        "4": "Ulubiony_kolor: czerwony",
        "5": "Ulubiony_autor: John Flanagan",
        "6": "Kolor_włosów: czarny",
        "7": "Data_urodzin: 26.04.2003"
};
print(Ja);
print("\n");

#Pytania o mnie
print("""
1. Wzrost
2. Wiek
3. Płeć
4. Ulubiony kolor
5. Ulubiony autor
6. Kolor włosów
7. Data urodzin

Co chcesz o mnie wiedzieć?""");

cyfra = input("Podaj cyfrę:");
if cyfra in Ja:
    Info = Ja[cyfra];
    print(Info);
else:
    print("Niepoprawna cyfra!");
print("\n");
    
#Muzycy i ich utwory
biblioteka = {
        muzycy[0]: ("Faded", "On my way", "End of time"),
        muzycy[1]: ("Fiji", "Wiatr", "Europa"),
        muzycy[2]: ("Kryptowaluty", "PIN", "Ecodiesel"),
        muzycy[3]: ("10/29", "Bez Strachu", "Gdybyś kiedyś"),
        muzycy[4]: ("Sweet but psycho", "So am I", "Who's laughing now")
    };
print(biblioteka);
