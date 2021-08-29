#Klasa Square ze zmienną klasową
class Shape():
    def what_am_i(self):
        print("Jestem figurą.")
        
class Square(Shape):

    square_list = [];
    
    def __init__(self, a):
        self.bok = a;
        self.square_list.append(self);

    def calculate_perimeter(self):
        return self.bok * 4;

S1 = Square(14);
S2 = Square(10);
S3 = Square(7);

print(Square.square_list);
print("\n");

#Klasa Square ze metodą magiczną
class Shape():
    def what_am_i(self):
        print("Jestem figurą.")
        
class Square(Shape):

    square_list = [];
    
    def __init__(self, a):
        self.bok = a;
        self.square_list.append(self);

    def calculate_perimeter(self):
        return self.bok * 4;

    def __repr__(self):
        return "{} na {} na {} na {}".format(self.bok, self.bok, self.bok, self.bok);

S1 = Square(14);
print(S1)
print("\n");

#Funkcja z Is
def Function(par1, par2):

    if par1 is par2:
        print(True);
    else:
        print(False);

Function(10, 100);
