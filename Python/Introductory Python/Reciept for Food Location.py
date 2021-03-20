#Author: Steve Lomeli
#Homework Number & Name: Homework 3 - Apotle
#Due Date: 2/17/2020
#Program Description: Apotle visit receipt

#Library to end script without closing interpreter
import sys

#Ask for name 
customer_name = input("Welcome to Apotle! What is your name? ")

#Initialize variables
burritos = 0
running_burritos = 0
tacos = 0
running_tacos = 0
fillings = 0
burritos_fillings = 0
tacos_fillings = 0
guacamole_burrito_price = 0
guacamole_taco_price = 0
extra_filling_price = 0
barbacoa = 8
carnitas = 7.50
veggie = 6.95

#Show menu
menu = int(input("MENU ITEMS\
\n1.Burrito\
\n2.Taco\
\n3.Complete my order\n"))

#If they do not order anything
while menu == 3:
    print("Nothing was purchased. Thank you for visiting us.")
    sys.exit()

#If they order either a burrito or taco
while menu != 3:

    #Must pick 1 - 3 validation
    while menu < 1 or menu > 3:
            menu = int(input("Invalid entry. Please select an option from above from 1 to 3.\n"))

    #If they ordered a burrito
    if menu == 1:

        #Ask for fillings
        fillings = int(input("FILLINGS\
        \n1.Barbacoa\
        \n2.Carnitas\
        \n3.Veggie\n"))

        #fillings validation
        while fillings < 1 or fillings > 3:
            fillings = int(input("Invalid entry. Please select an option from above from 1 to 3.\n"))

        #Guacamole
        burrito_guacamole = input("Would you like guacamole? Y/y or N/n ")

        #Guacamole validation
        while burrito_guacamole != "Y" and burrito_guacamole != "y" and \
              burrito_guacamole != "N" and burrito_guacamole != "n":
            burrito_guacamole = input("Invalid entry. Please type either Y/y or N/n.\n")

        #Extra Filling? 
        extra_filling = input("Would you like extra filling? Y/y or N/n ")

        #Filling validation
        while extra_filling != "Y" and extra_filling != "y" and \
              extra_filling != "N" and extra_filling != "n":
            extra_filling = input("Invalid entry. Please type either Y/y or N/n.\n")

        #Quantity of this specific burritos 
        burritos_quantity = int(input("How many of these burritos would you like? "))

        #burritos quantity validation
        while burritos_quantity <= 0:
            burritos_quantity = int(input("Invalid entry. Please type an option greater than 0.\n"))          

        #assign current burritos quantity
        burritos = burritos_quantity

        #fillings, starting with barbacoa
        if fillings == 1:
            burritos_fillings += (8 * burritos)
        #Carnitas
        elif fillings == 2:
            burritos_fillings += (7.50 * burritos)
        #Veggie
        else:
            burritos_fillings += (6.95 * burritos)

        #Filling price
        if extra_filling == "Y" or extra_filling == "y":
            extra_filling_price += (3.35 * burritos)

        #Guacamole price
        if burrito_guacamole == "Y" or burrito_guacamole == "y":
            guacamole_burrito_price += (2.05 * burritos)

        #Assign running value for total at the end
        running_burritos += burritos

    #If they ordered tacos
    if menu == 2:
        
        #Ask for fillings
        fillings = int(input("FILLINGS\
        \n1.Barbacoa\
        \n2.Carnitas\
        \n3.Veggie\n"))

        #fillings validation
        while fillings < 1 or fillings > 3:
            fillings = int(input("Invalid entry. Please select an option from above from 1 to 3.\n"))

        #Guacamole for tacos
        taco_guacamole = input("Would you like guacamole? Y/y or N/n ")

        #Guacamole validation
        while taco_guacamole != "Y" and taco_guacamole != "y" and \
              taco_guacamole != "N" and taco_guacamole != "n":
            taco_guacamole = input("Invalid entry. Please type either Y/y or N/n.\n")

        #Quantity of specific tacos
        tacos_quantity = int(input("How many of these tacos would you like? "))

        #tacos_quantity validation
        while tacos_quantity < 1 or  tacos_quantity > 3:
            tacos_quantity = int(input("Invalid entry. Please type a number from 1 to 3.\n"))
            
        #assign current tacos quantity
        tacos = tacos_quantity

        #Price of guacamole for tacos
        if (taco_guacamole == "Y" or taco_guacamole == "y") and tacos == 1:
            guacamole_taco_price += .75
        elif (taco_guacamole == "Y" or taco_guacamole == "y") and tacos == 2:
            guacamole_taco_price += 1.5
        elif (taco_guacamole == "Y" or taco_guacamole == "y") and tacos == 3:
            guacamole_taco_price += 2.05
        
        #Barbacoa
        if fillings == 1 and tacos == 1:
            tacos_fillings += (barbacoa/3)
        elif fillings == 1 and tacos == 2:
            tacos_fillings += ((barbacoa/3) * 2)
        elif fillings == 1 and tacos == 3:
            tacos_fillings += barbacoa

        #Carnitas
        if fillings == 2 and tacos == 1:
            tacos_fillings += (carnitas/3)
        elif fillings == 2 and tacos == 2:
            tacos_fillings += ((carnitas/3) * 2)
        elif fillings == 2 and tacos == 3:
            tacos_fillings += carnitas
            
        #Veggie
        if fillings == 3 and tacos == 1:
            tacos_fillings += (veggie/3)
        elif fillings == 3 and tacos == 2:
            tacos_fillings += ((veggie/3) * 2)
        elif fillings == 3 and tacos == 3:
            tacos_fillings += veggie

        #Assign running value for total at the end
        running_tacos += tacos

    
    #Ask if they will add anything else
    print()
    menu = int(input("MENU ITEMS\
    \n1.Burrito\
    \n2.Taco\
    \n3.Complete my order\n"))

#Blank line
print()

#Calculate total price for tacos
tacos_total = guacamole_taco_price + tacos_fillings

#Calculate total price for burritos
burritos_total = ((burritos_fillings + guacamole_burrito_price + extra_filling_price))

#Combine tacos and burritos price
combined_price = tacos_total + burritos_total

#Find sales tax
sales_tax = combined_price * .0825

#Find total amount due (tax + price)
amount_due = combined_price + sales_tax

#Print all calculations5
print("Customer Name:", customer_name)
print("Number of burritos:", running_burritos)
print("Number of tacos:", running_tacos)
print("Total price: " + "$"  + str(format(combined_price,',.2f')))
print("Sales tax: " + "$" + str(format(sales_tax,',.2f')))
print("Total amount due: " + "$" + str(format(amount_due,',.2f')))
      

