class Entree:

    #Initializing class
    def __init__(self, start_name, start_qty):
        self.__name = start_name
        self.__quantity = start_qty

    #Get name 
    def get_name(self):
        return self.__name

    #Get quantity
    def get_qty(self):
        return self.__quantity

    #Print attributes
    def __str__(self):
        print("Summary:")
        print("Name:", self.__name)
        print("Quantity:", self.__quantity)
        return ""
    
