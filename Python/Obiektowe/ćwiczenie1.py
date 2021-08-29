#Klasa Apple
class Apple():
    def __init__(self, k, o, w, j):
        self.kolor = k;
        self.odmiana = o;
        self.wielkosc = w;
        self.jakosc = j;

#Klasa Circle
import math;
        
class Circle():
    def __init__(self, r):
        self.promien = r;

    def area(self):
        return self.promien * math.pi;

circle = Circle(1);
print(circle.area());
print("\n");

#Klasa Triangle
class Triangle():
    def __init__(self, a, h):
        self.bok = a;
        self.wys = h;

    def area(self):
        return (self.bok * self.wys)/2;

triangle = Triangle(15, 4);
print(triangle.area());
print("\n")

#Klasa Hexagon
class Hexagon():
    def __init__(self, a, b, c, x, y, z):
        self.bok1 = a;
        self.bok2 = b;
        self.bok3 = c;
        self.bok4 = x;
        self.bok5 = y;
        self.bok6 = z;

    def calculate_perimeter(self):
        return self.bok1 + self.bok2 + self.bok3 + self.bok4 + self.bok5 + self.bok6;

hexagon = Hexagon(3,10,4,8,11,2);
print(hexagon.calculate_perimeter());
