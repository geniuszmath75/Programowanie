#Klasy Rectangle i Square
class Rectangle():
    def __init__(self, a, b):
        self.dl = a;
        self.szer = b;

    def calculate_perimeter(self):
        return 2 * self.dl + 2 * self.szer;

class Square():
    def __init__(self, a):
        self.bok = a;

    def calculate_perimeter(self):
        return 4 * self.bok;

r_perimeter = Rectangle(4, 10);
s_perimeter = Square(5);

print(r_perimeter.calculate_perimeter());
print(s_perimeter.calculate_perimeter());
print("\n");

#Klasa Square(inna)
class Square():
    def __init__(self, a):
        self.bok = a;

    def calculate_perimeter(self):
        return self.bok * 4;

    def change_size(self, i):
        self.bok += i;

podaj_bok = Square(4);
print(podaj_bok.bok);
podaj_bok.change_size(5);
print(podaj_bok.bok);
print("\n");

#Klasa Shape
class Shape():
    def what_i_am(self):
        print("Jestem figurą!");

class Rectangle2(Shape):
    def __init__(self, a, b):
        self.dl = a;
        self.szer = b;

    def calculate_perimeter(self):
        return 2 * self.dl + 2 * self.szer;

class Square2(Shape):
    def __init__(self, a):
        self.bok = a;

    def calculate_perimeter(self):
        return self.bok * 4;

a_rectangle = Rectangle2(4,10);
b_square = Square2(5);
a_rectangle.what_i_am();
b_square.what_i_am();
print("\n");

#Klasa Horse i Rider
class Horse():
    def __init__(self, name, color, owner):
        self.name = name;
        self.color = color;
        self.owner = owner;

class Rider():
    def __init__(self, name):
        self.name = name;

jan = Rider("Jan Kowalski");
romek = Horse("Romek", "czarny", jan);
print(romek.owner.name);
