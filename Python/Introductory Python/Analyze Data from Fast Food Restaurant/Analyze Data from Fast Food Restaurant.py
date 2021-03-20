#Author: Steve Lomeli
#Homework Number & Name: Homework 7 - Fast Food Resturaunt
#Due Date: 4/13/2020
#Program Description: Analyze data from fast food resturaunt

def main():

    #Name constants
    ORDERS_FILE_NAME = 'orders-sample.txt'
    BURGER_PRICE = 7.95
    SALAD_PRICE = 8.50
    SANDWICH_PRICE = 6.75
    CHEESE_PRICE = 1.00
    TOMATO_PRICE = 0.50
    AVOCADO_PRICE = 1.50

    #Process data
    burgers_dictionary, sandwich_dictionary, salad_dictionary, \
    total_revenue_dictionary, burger_set, sandwich_set, salad_set = processInput(ORDERS_FILE_NAME, BURGER_PRICE, SANDWICH_PRICE, SALAD_PRICE, CHEESE_PRICE, TOMATO_PRICE, AVOCADO_PRICE)

    #Write to file
    writeToFile(burgers_dictionary, sandwich_dictionary, salad_dictionary, total_revenue_dictionary)

    #Display menu
    choice = printMenu()

    #Process choices
    while choice != 10:
        if choice == 1: #Customer purchased most of each product
            maxBurger, numberBurger = findBestCustomer(burgers_dictionary)
            maxSandwich, numberSandwich = findBestCustomer(sandwich_dictionary)
            maxSalad, numberSalad = findBestCustomer(salad_dictionary)
            print(maxBurger,"ordered", numberBurger,"burgers")
            print(maxSalad,"ordered",numberSalad,"salads")
            print(maxSandwich,"ordered",numberSandwich,"sandwiches")
            
        elif choice == 2: #Customer generated most revenue
            maxRevenue, number = findBestCustomer(total_revenue_dictionary)
            print(maxRevenue,"generated" + " $" + format(number,".2f"))

        elif choice == 3: #Customers who purchased all
            intersection = burger_set.intersection(sandwich_set).intersection(salad_set)
            sortedNames, numberOfNames = printNames(intersection)
            for name in sortedNames:
                print(name)
            print("The number of customers is:", numberOfNames)

        elif choice == 4: #two types of products
            difference = burger_set.symmetric_difference(sandwich_set).symmetric_difference(salad_set)
            union = burger_set.union(sandwich_set).union(salad_set)
            total = union - difference 
            sortedNames, numberOfNames = printNames(total)
            for name in sortedNames:
                print(name)
            print("The number of customers is:", numberOfNames)

        elif choice == 5: #one type of product
            symmetric_difference = burger_set.symmetric_difference(sandwich_set).symmetric_difference(salad_set)
            union = burger_set.union(sandwich_set).union(salad_set)
            intersection = burger_set.intersection(sandwich_set).intersection(salad_set)
            total = union - symmetric_difference
            newTotal = union - total - intersection
            sortedNames, numberOfNames = printNames(newTotal)
            for name in sortedNames:
                print(name)
            print("The number of customers is:", numberOfNames)

        elif choice == 6: #Burgers
            difference = burger_set.difference(sandwich_set).difference(salad_set)
            sortedNames, numberOfNames = printNames(difference)
            for name in sortedNames:
                print(name)
            print("The number of customers is:", numberOfNames)

        elif choice == 7: #Sandwich
            difference = sandwich_set.difference(burger_set).difference(salad_set)
            sortedNames, numberOfNames = printNames(difference)
            for name in sortedNames:
                print(name)
            print("The number of customers is:", numberOfNames)

        elif choice == 8: #Salad
            difference = salad_set.difference(burger_set).difference(sandwich_set)
            sortedNames, numberOfNames = printNames(difference)
            for name in sortedNames:
                print(name)
            print("The number of customers is:", numberOfNames)

        elif choice == 9: #Total revenue generated
            total = 0
            for customer in total_revenue_dictionary:
                amount = total_revenue_dictionary[customer]
                total += amount
            print("Total revenue generated:" + " $" + format(total,",.2f"))
        #Once one choice is made, bring up menu again
        choice = printMenu()

#Menu function
def printMenu():
    choice = int(input('PURCHASE HISTORY ANALYSIS\n\
1. Who purchased the most of each item?\n\
2. Who generated the most revenue?\n\
3. Which customers purchased burgers, salads, and sandwiches?\n\
4. Which customers purchased two types of products?\n\
5. Which customers purchased one type of product?\n\
6. Which customers purchased only burgers?\n\
7. Which customers purchased only sandwiches?\n\
8. Which customers purchased only salads?\n\
9. What is the total revenue generated by all customers?\n\
10. Exit\n'))

    #Menu validation
    while choice <= 0 or choice > 10:
        choice = int(input("Invalid entry. Please re-enter: "))

    return choice

#Process file function
def processInput(file, BURGER_PRICE, SANDWICH_PRICE, SALAD_PRICE, CHEESE_PRICE, TOMATO_PRICE, AVOCADO_PRICE):

    #Open file
    order_file = open(file,'r')

    #Create dictionaries/sets
    burgers_dictionary = {}
    sandwich_dictionary = {}
    salad_dictionary = {}
    total_revenue_dictionary = {}
    burger_set = set()
    sandwich_set = set()
    salad_set = set()

    #Iterate through file
    for customer in order_file:
        #Split line on * and remove spaces
        customer_order = customer.split('*')
        customer_order[-1] = customer_order[-1].strip()

        #Fix cases and extraneous spaces
        nameCase = customer_order[0]
        nameCase = " ".join(nameCase.split())
        customer_order[0] = nameCase.title()

        #Make this index a type int
        int(customer_order[3])

        #If customer ordered a burger
        if customer_order[2] == 'Burger':

            #Get price and calculate revenue
            price = calculateOrderPrice(customer_order, BURGER_PRICE, SANDWICH_PRICE, SALAD_PRICE, CHEESE_PRICE, TOMATO_PRICE, AVOCADO_PRICE, total_revenue_dictionary)

            #Add count to person's total 
            if customer_order[0] in burgers_dictionary:
                count = burgers_dictionary[customer_order[0]]
                burgers_dictionary[customer_order[0]] = count + int(customer_order[3])
            elif customer_order[0] not in burgers_dictionary:
                burgers_dictionary[customer_order[0]] = int(customer_order[3])

            #Add customer to set
            burger_set.add(customer_order[0])

        #If customer ordered a sandwich          
        if customer_order[2] == 'Sandwich':

            #Get price and calculate revenue
            price = calculateOrderPrice(customer_order, BURGER_PRICE, SANDWICH_PRICE, SALAD_PRICE, CHEESE_PRICE, TOMATO_PRICE, AVOCADO_PRICE, total_revenue_dictionary)

            #Add count to person's total 
            if customer_order[0] in sandwich_dictionary:
                count = sandwich_dictionary[customer_order[0]]
                sandwich_dictionary[customer_order[0]] = count + int(customer_order[3])  
            elif customer_order[0] not in sandwich_dictionary:
                sandwich_dictionary[customer_order[0]] = int(customer_order[3])

            #Add customer to set
            sandwich_set.add(customer_order[0])

        #If customer ordered a salad
        if customer_order[2] == 'Salad':

            #Get price and calculate revenue
            price = calculateOrderPrice(customer_order, BURGER_PRICE, SANDWICH_PRICE, SALAD_PRICE, CHEESE_PRICE, TOMATO_PRICE, AVOCADO_PRICE, total_revenue_dictionary)

            #Add count to person's total
            if customer_order[0] in salad_dictionary:
                count = salad_dictionary[customer_order[0]]
                salad_dictionary[customer_order[0]] = count + int(customer_order[3])
            elif customer_order[0] not in salad_dictionary:
                salad_dictionary[customer_order[0]] = int(customer_order[3])

            #Add data to set
            salad_set.add(customer_order[0])

    #Close file at end
    order_file.close()
    
    return burgers_dictionary, sandwich_dictionary, salad_dictionary, \
           total_revenue_dictionary, burger_set, sandwich_set, salad_set
    
def calculateOrderPrice(customer_order, BURGER_PRICE, SANDWICH_PRICE, SALAD_PRICE, CHEESE_PRICE, TOMATO_PRICE, AVOCADO_PRICE, total_revenue_dictionary):

    #Seperate by what they ordered and calculate price
    if customer_order[2] == 'Burger':
        food_price = float(customer_order[3]) * BURGER_PRICE
        toppings = ((float(customer_order[4]) * CHEESE_PRICE) \
                   + (float(customer_order[5]) * TOMATO_PRICE)\
                   + (float(customer_order[6]) * AVOCADO_PRICE)) * float(customer_order[3])
        price = toppings + food_price
        
    elif customer_order[2] == 'Sandwich':
        food_price = float(customer_order[3]) * SANDWICH_PRICE
        toppings = ((float(customer_order[4]) * CHEESE_PRICE)\
                   + (float(customer_order[5]) * TOMATO_PRICE)\
                   + (float(customer_order[6]) * AVOCADO_PRICE)) * float(customer_order[3])
        price = toppings + food_price

    elif customer_order[2] == 'Salad':
        food_price = float(customer_order[3]) * SALAD_PRICE
        toppings = ((float(customer_order[4]) * CHEESE_PRICE)\
                   + (float(customer_order[5]) * TOMATO_PRICE)\
                   + (float(customer_order[6]) * AVOCADO_PRICE)) * float(customer_order[3])
        price = toppings + food_price

    #Assign 0 if they aren't yet in dictionary
    if customer_order[0] not in total_revenue_dictionary:
        total_revenue_dictionary[customer_order[0]] = 0

    #Add past price + new price to get current price   
    past_price = total_revenue_dictionary[customer_order[0]]
    total_revenue_dictionary[customer_order[0]] = past_price + price

    return price

def findBestCustomer(dict_name):
    #Find best customer from dictionary and bring back name and number
    bestCustomer = max(dict_name, key=dict_name.get)
    number = dict_name[bestCustomer]
    
    return bestCustomer, number

def printNames(customerNames):
    #Sort alphabetically and bring back names and number of names
    sortedNames = sorted(customerNames)
    numberOfNames = len(sortedNames)

    return sortedNames, numberOfNames

def writeToFile(burgers_dictionary, sandwich_dictionary, salad_dictionary,total_revenue_dictionary):

    #Name constants
    BURGERS_FILE = 'burgers.txt'
    SANDWICHES_FILE = 'sandwiches.txt'
    SALADS_FILE = 'salads.txt'
    REVENUE_FILE = 'revenue.txt'

    #Open files
    burgersText = open(BURGERS_FILE,'w')
    sandwichText = open(SANDWICHES_FILE,'w')
    saladText = open(SALADS_FILE,'w')
    revenueText = open(REVENUE_FILE,'w')

    #Write to files, ignore extra comments. Those are to sort alphabetically
    #burgers_dictionary = sorted(burgers_dictionary.items(), key=lambda x: -x[1])
    for i,j in burgers_dictionary.items():
        burgers = str(i) + " " + str(j)
        burgersText.write(burgers + "\n")
        
    #sandwich_dictionary = sorted(sandwich_dictionary.items(), key=lambda x: -x[1])
    for i,j in sandwich_dictionary.items():
        sandwiches = str(i) + " " + str(j)
        sandwichText.write(sandwiches + "\n")

    #salad_dictionary = sorted(salad_dictionary.items(), key=lambda x: -x[1])
    for i,j in salad_dictionary.items():
        salad = str(i) + " " + str(j)
        saladText.write(salad + "\n")

    #total_revenue_dictionary = sorted(total_revenue_dictionary.items(), key=lambda x: -x[1])
    for i,j in total_revenue_dictionary.items():
        rev = str(i) + " $" + format(j,".2f")
        revenueText.write(rev + "\n")

    #Close files
    burgersText.close()
    sandwichText.close()
    saladText.close()
    revenueText.close()

   
main()

    