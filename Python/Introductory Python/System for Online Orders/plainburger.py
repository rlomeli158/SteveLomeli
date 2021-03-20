
#Constants
PRICE_6OZ = 5.99
PRICE_8OZ = 7.99
PRICE_10OZ = 9.99

#Import inherited superclass
import superclass

class PlainBurger(superclass.Entree):

    #Initalize with inherited class
    def __init__(self, name, qty, size):
        super().__init__(name, qty)
        self.__size = size
        self.__price = self.set_price()

    #Return size
    def get_size(self):
        return self.__size

    #Set price depending on size
    def set_price(self):
        if self.__size == "6oz":
            price = PRICE_6OZ
            return price
        elif self.__size == "8oz":
            price = PRICE_8OZ
            return price
        elif self.__size == "10oz":
            price = PRICE_10OZ
            return price

    #Return price
    def get_price(self):
        return self.__price

    #Calculate cost
    def calc_cost(self):
        self.__cost = self.get_qty() * self.__price
        return self.__cost

    #Print attributes
    def __str__(self):
        print(self.get_qty(), "Plain Burger(s)", self.__size + " $" + format(self.calc_cost(), ",.2f"))
        
        return ""
        
        
