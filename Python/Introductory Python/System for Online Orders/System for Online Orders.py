#Author: Steve Lomeli
#Homework Number & Name: Homework 9 - Diner New System
#Due Date: 4/27/2020
#Program Description: Building a new system to handle online orders for curbside pickup

#Import classes
import pizzaslice
import plainburger
import deluxeburger

#Define Menu function
def menu():
    menu = "Entree Menu\n\
1. Pizza slice\n\
2. Plain burger\n\
3. Deluxe burger \n\
4. Complete order\n\
Your selection: "
    return menu

#Validate choice from menu
def validateChoice(menu):
    choice = int(input(menu))

    while choice > 4 or choice < 1:
        choice = int(input("Invalid choice. Must be greater than 1 or less than 4: "))

    return choice

#Validate quantity ordered
def validateQuantity(quantity):
    while quantity <= 0:
        quantity = int(input("Invalid entry. Must be greater than 0: "))
    return quantity

#Define invoice printing function
def invoice(shapelist, pizza, burger, deluxe):
    pizza_cost = 0
    burger_cost = 0
    deluxe_cost = 0
    total = 0
    counter = 0

    #Iterate through list to get total and print each item
    for i in shapelist:
        print(i)
        counter += i.get_qty()
        total += i.calc_cost()

    #Calculate tax
    totalWithTax = total * 1.0825
    tax = total * .0825

    #If they ordered nothing, thank them
    if total == 0:
        print("Thank you for visiting!")

    #Print final totals
    if total != 0:
        print("Total entrees:", counter)
        print("Subtotal: $" + format(total,",.2f"))
        print("Tax: $" + format(tax,",.2f"))
        print("Total due: $" + format(totalWithTax,",.2f"))

def main():
    pizza = 0
    burger = 0
    deluxe = 0
    shapelist = []

    #Get validated choice from menu
    choice = validateChoice(menu())

    #While they dont finalize their order
    while choice != 4:

        #If they want pizza
        if choice == 1:
            pizzaQuantity = int(input("How many slices of pizza would you like? "))
            validateQuantity(pizzaQuantity)
            pizzaToppings = int(input("How many toppings would you like? "))
            while pizzaToppings <0:
                pizzaToppings = int(input("Invalid input. Cannot be negative."))
            pizza = pizzaslice.PizzaSlice("Pizza", pizzaQuantity, pizzaToppings)
            shapelist.append(pizza)

        #If they want a regular burger
        elif choice == 2:
            burgerQuantity = int(input("How many burgers would you like? "))
            validateQuantity(burgerQuantity)
            burgerSize = input("What size would you like your burger? i.e 6oz, 8oz, 10oz: ")
            while burgerSize != "6oz" and burgerSize != "8oz" and burgerSize != "10oz":
                burgerSize = input("Invalid input. Try again i.e 6oz, 8oz, 10oz: ")
            burger = plainburger.PlainBurger("Burger", burgerQuantity, burgerSize)
            shapelist.append(burger)

        #If they want a deluxe burger
        elif choice == 3:
            deluxeQuantity = int(input("How many burgers would you like? "))
            validateQuantity(deluxeQuantity)
            deluxeSize = input("What size would you like your burger? i.e 6oz, 8oz, 10oz: ")
            while deluxeSize != "6oz" and deluxeSize != "8oz" and deluxeSize != "10oz":
                deluxeSize = input("Invalid input. Try again i.e 6oz, 8oz, 10oz: ")
            deluxe = deluxeburger.DeluxeBurger("Burger", deluxeQuantity, deluxeSize)

            #If they want cheese
            cheese = input("Would you like cheese on it? Y/y or  N/n ")
            while cheese != "Y" and cheese != "y" and cheese != "N" and cheese != "n":
                cheese = input("Invalid entry. Please enter Y/y or N/n. ")
            if cheese == "Y" or cheese == "y":
                deluxe.get_cheese()

            #If they want bacon
            bacon = input("Would you like bacon on it? Y/y or  N/n ")
            while bacon != "Y" and bacon != "y" and bacon != "N" and bacon != "n":
                bacon = input("Invalid entry. Please enter Y/y or N/n. ")
            if bacon == "Y" or bacon == "y":
                deluxe.get_bacon()

            #If they want avocado
            avocado = input("Would you like avocado on it? Y/y or  N/n ")
            while avocado != "Y" and avocado != "y" and avocado != "N" and avocado != "n":
                avocado = input("Invalid entry. Please enter Y/y or N/n. ")
            if avocado == "Y" or avocado == "y":
                deluxe.get_avocado()
                
            shapelist.append(deluxe)
                
        print()
        #Get next choice
        choice = validateChoice(menu())

    #Print out invoice
    if choice == 4:
        print()
        invoice(shapelist, pizza, burger, deluxe)

main()
