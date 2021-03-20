#Author: Steve Lomeli
#Homework Number & Name: Homework 4 - Department of Benefits
#Due Date: 3/2/2020
#Program Description: Calculate employee benefits for UT


#Get number of employees to process
def numberOfEmployees():
    numberOfEmp = int(input("How many employees do you want to process? "))
    while numberOfEmp <= 0:
        numberOfEmp = int(input("Invalid entry. Must be greater than 0: "))
    return numberOfEmp

#Get employee type: salary/hourly
def employeeType(name):
    empType = input("What is " + name + "'s "+"employee type? \nS/s for salaried; H/h for hourly: ")
    while empType != "S" and empType != "s" and empType != "H" and empType != "h":
        empType = input("Invalid input. Enter S/s or H/h : ")
    if empType == "S" or empType == "s":
        empType = "salaried"
    else:
        empType = "hourly"
    return empType

#Get salary amount
def salaryAmount(name): #if salary
    salary = float(input("What is " + name + "'s " + "salary? $"))
    while salary <= 0:
        salary = float(input("Invalid input. Must be greater than 0: $"))
    hours = 0
    hourlyRate = 0
    return salary, hours, hourlyRate

#Get hourly wage
def hourlyWage(name): #if hourly
    hourlyRate = float(input("How much is" + " " + name + "'s " + "hourly rate? $"))
    while hourlyRate <= 0:
        hourlyRate = float(input("Invalid input. Must be greater than 0: $"))
    retirement = "n"
    retirementContributionAmount = 0
    return hourlyRate, retirement, retirementContributionAmount

#Get hours worked
def hoursWorked(name): #if hourly
    hours = float(input("How many hours did " + name + " work? "))
    while hours <= 0:
        hours = float(input("Invalid input. Must be greater than 0."))
    salary = 0
    return hours, salary

#Determine whether they contributed to 401K if they were salaried
def retirementContribution(salary, name):
    retirement = input("Does " + name + " contribute to a 401K? Y/y or N/n: ")
    while retirement != "Y" and retirement != "y" and retirement != "N" and retirement != "n":
        retirement = input("Invalid input. Enter Y/y or N/n: ")
    if retirement == "N" or retirement == "n":
        retirement = 0
    return retirement
    
#Get what health insurance the employee has
def healthInsurance(name):
    health = input("What type of health insurance does " + name + " have? \n\
HMO/PPO/None? Spell it how you see it: ")
    while health != "HMO" and health != "PPO" and health != "None":
        health = input("Invalid input. Select HMO/PPO/None: ")
    return health

#See if employee has life insurance or not
def lifeInsurance(name):
    life = input("Has "+ name + " selected life insurance? Y/y or N/n: ")
    while life != "Y" and life != "y" and life != "N" and life != "n":
        life = input("Invalid input. Enter Y/y or N/n: ")
    if life == "Y" or life == "y":
        life = "Y"
    else:
        life = "N"
    return life
    
#Calculate health insurance cost
def healthInsuranceCost(health):
    if health == "HMO":
        healthCost = 120 * 12
    elif health == "PPO":
        healthCost = 180 * 12
    else:
        healthCost = 0
    return healthCost    

#Calculate retirement contribution amount
def retirementContributionAmt(salary, retirement):
    if salary == 0 or retirement == 0:
        retirementContributionAmount = 0
    else:
        retirementContributionAmount = salary * .05
    return retirementContributionAmount
        
#Calculate cost for life insurance
def lifeInsuranceCost(life, empType, salary, hours, hourlyRate):
    if empType == "salaried" and life == "Y" or life == "y":
        lifeInsurance = .01 * salary
    elif empType == "hourly" and life == "Y" or life == "y":
        lifeInsurance = .01 * (hours * hourlyRate)
    else:
        lifeInsurance = 0
    return lifeInsurance

#Get employee's name
def getName():
    name = str(input("What is the employee's name? "))
    return name

#Print statement at the end of each individual employee
def printEverything(name, empType, life, salary, hours,\
                    retirement, retirementContributionAmount, \
                    hourlyRate, health, healthCost, lifeInsuranceTotal):
    if empType == "salaried":
        if lifeInsuranceTotal > 0:
            if healthCost > 0 and retirementContributionAmount == 0:
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + ", pays $" + str(format((lifeInsuranceTotal),',.2f')) + \
                                  " for life insurance, and pays $ " + str(format(healthCost,',.2f')) + \
                                  " for health insurance.")
                #statement = print("health, not 401K")
            elif healthCost > 0 and retirementContributionAmount > 0:
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + ", pays $" + str(format(retirementContributionAmount,',.2f')) + \
                                  " to 401K, pays $" + str(format(healthCost,',.2f')) + \
                                  " for health insurance, and pays $" + str(format((lifeInsuranceTotal),',.2f'))+ \
                                  " for life insurance.")
                #statement = print("health, and 401k")
            elif healthCost == 0 and retirementContributionAmount == 0:
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + " and pays $" + str(format((lifeInsuranceTotal),',.2f')) + " to life insurance.")
                #statement =print("not health, not 401K")
        elif healthCost > 0:
            if lifeInsuranceTotal == 0 and retirementContributionAmount == 0:
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + " and pays $" + str(format(healthCost,',.2f')) + " to health insurance.")
                #statement = print("not life, not 401K")
        elif retirementContributionAmount > 0:
            if healthCost > 0 and lifeInsuranceTotal == 0:
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + ", pays $" + str(format(retirementContributionAmount,',.2f')) + \
                                  " to 401K, and pays $" + str(format(healthCost,',.2f')) + \
                                  " for health insurance.")
                #statement = print("health, not life")
            if lifeInsuranceTotal > 0 and healthCost == 0:
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + ", pays $" + str(format(retirementContributionAmount,',.2f')) + \
                                  " to 401K, and pays $" + str(format((lifeInsuranceTotal),',.2f')) + \
                                  " for life insurance.")
                #statement = print("life, not health")
            if healthCost == 0 and lifeInsuranceTotal == 0:
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + " and pays $" + str(format(retirementContributionAmount,',.2f')) + \
                                  " to 401K.")
                #statement = print("not health, not life")
        else:
            statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format(salary,',.2f')) + ".")
    elif empType == "hourly":
        if lifeInsuranceTotal > 0:
            if healthCost > 0: 
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format((hours * hourlyRate),',.2f')) + ", pays $" + str(format((lifeInsuranceTotal),',.2f')) + " for life insurance ,"+ \
                 " and pays $" + str(format((healthCost),',.2f')) + " for health insurance.")
            else: 
                statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format((hours * hourlyRate),',.2f')) + " and pays $" + str(format((lifeInsuranceTotal),',.2f')) + " for life insurance.")
        elif health != "None":
            statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format((hours * hourlyRate),',.2f')) + " and pays $" + str(format(healthCost,',.2f')) + " for health insurance.")
        else: 
            statement = print(name + " is a " + empType + " employee and earns " + \
                  "$" + str(format((hours * hourlyRate),',.2f')) + ".")

    #return statement

#Main function and logic
def main():

    #Accumulator variables
    sumWages = 0
    sumRetirementContributions = 0
    sumLifeInsurance = 0
    sumHealthCosts = 0
    
    numberOfEmp = numberOfEmployees()
    for i in range(1,numberOfEmp+1):
        name = getName()
        empType = employeeType(name)

        #If employee is salaried
        if empType == "salaried":
            salary, hours, hourlyRate = salaryAmount(name)
            retirement = retirementContribution(salary, name)
            sumWages += salary
            
            #Calculate retirement amounts
            retirementContributionAmount = retirementContributionAmt(salary, retirement)
            sumRetirementContributions += retirementContributionAmount

        #If employee is hourly
        else:
            hours, salary = hoursWorked(name)
            hourlyRate, retirement, retirementContributionAmount = hourlyWage(name)
            sumWages += (hours * hourlyRate)
            

        #life insurance cost
        life = lifeInsurance(name)
        lifeInsuranceTotal = lifeInsuranceCost(life, empType, salary, hours, hourlyRate)
        sumLifeInsurance += lifeInsuranceTotal

        #health insurance cost
        health = healthInsurance(name)
        healthCost = healthInsuranceCost(health)
        sumHealthCosts += healthCost

        print()

        #Print summary
        printEverything(name, empType, life, salary, hours,\
                              retirement, retirementContributionAmount, \
                              hourlyRate, health, healthCost, \
                              lifeInsuranceTotal)

    #Print totals    
    print()
    print("Total Wages: $", str(format(sumWages,',.2f')))
    print("Total Retirement Contributions: $", str(format(sumRetirementContributions,',.2f')))
    print("Total Life Insurance Costs: $", str(format(sumLifeInsurance,',.2f')))
    print("Total Health Costs: $", str(format(sumHealthCosts,',.2f')))

    #End of main      
    
main()

