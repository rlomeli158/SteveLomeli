
#Constants
CHEESE = 0.99
BACON = 1.79
AVOCADO = 1.99

#Import superclass
import plainburger

class DeluxeBurger(plainburger.PlainBurger):

    #Initialize with PlainBurger attributes inherited
    def __init__(self, name, qty, size):
        super().__init__(name, qty, size)
        self.__price = self.set_price()
        self.__size = size
        self.__cheese = False
        self.__bacon = False
        self.__avocado = False

    #Want cheese, bacon or avocado
    def get_cheese(self):
        self.__cheese = True
    def get_bacon(self):
        self.__bacon = True
    def get_avocado(self):
        self.__avocado = True

    #Remove cheese, bacon or avocado
    def remove_cheese(self):
        self.__chese = False
    def remove_bacon(self):
        self.__bacon = False
    def remove_avocado(self):
        self.__avocado = False

    #Calculate total cost depending on if they had certain toppings
    def calc_cost(self):
        
        if self.__cheese == True:
            cheese_price = CHEESE
        else:
            cheese_price = 0
        if self.__bacon == True:
            bacon_price = BACON
        else:
            bacon_price = 0
        if self.__avocado == True:
            avocado_price = AVOCADO
        else:
            avocado_price = 0
            
        self.__cost = self.get_qty() * (self.__price + cheese_price + bacon_price + avocado_price)
        return self.__cost

    #Print attributes
    def __str__(self):
        print(self.get_qty(), "Deluxe Burger(s)", self.__size, "Toppings: ", end='')
        if self.__cheese == True:
            print("cheese ", end='')
        if self.__bacon == True:
            print("bacon ", end='')
        if self.__avocado == True:
            print("avocado ",end='')
        print("$" + format(self.calc_cost(),",.2f"))
        
        return ""

