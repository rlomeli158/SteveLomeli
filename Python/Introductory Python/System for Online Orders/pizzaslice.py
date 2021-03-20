
#Constants
PIZZA = 1.99
TOPPING = 0.99

#Import the inherited superclass
import superclass

class PizzaSlice(superclass.Entree):

    #Initialize with inherited attributes
    def __init__(self, name, qty, toppings):
        super().__init__(name, qty)
        self.__toppings = toppings

    #Return toppings
    def get_toppings(self):
        return self.__toppings

    #Calculate total cost
    def calc_cost(self):
        if self.__toppings == 0:
            self.cost = self.get_qty() * PIZZA
            return self.cost
        else:
            self.cost = (self.get_qty() * PIZZA) + (self.get_qty() * self.__toppings * TOPPING)
            return self.cost

    #Print attributes
    def __str__(self):
        print(self.get_qty(),"Pizza Slice(s) ", end = '')
        if self.__toppings != 0:
            print(self.get_toppings(), "Toppings ", end = '')
        print("$" + format(self.calc_cost(),",.2f"))
        return ""
        
    
