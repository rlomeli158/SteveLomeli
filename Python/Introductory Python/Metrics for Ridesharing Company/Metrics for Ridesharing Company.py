#Author: Steve Lomeli
#Homework Number & Name: Homework 5 - Rideshare Competitor Statistics
#Due Date: 3/09/2020
#Program Description: Calculate metrics for a rideshare company 

def main():
    import sys
    
    #Accumulator variables
    totalDrivers = 0
    totalMiles = 0
    totalMinutes = 0
    totalTrips = 0
    totalRevenue = 0
    driverMiles = 0
    driverMinutes = 0

    #CONSTANTS
    DRIVERDATAFILE = 'driverdata.txt'
    OUTPUTFILE = 'summarydriverdata.txt'
    BASEFARE = 1.05
    MILEFARE = .95
    MINFARE = .15

    #clear output file from prior data
    open(OUTPUTFILE, 'w').close()

    #open input file
    try: 
        dataDriver = open(DRIVERDATAFILE,'r')
    except:
        print("The driver data file is not found.")
        sys.exit()

    #Get drivers, rides mileage and time
    driverId = dataDriver.readline().rstrip('\n')
    while driverId != '':
        
        carType = dataDriver.readline().rstrip('\n')
        numberRides = int(dataDriver.readline().rstrip('\n'))

        #Set miles/minutes to zero and add a driver each loop
        totalDrivers += 1
        driverMiles = 0
        driverMinutes = 0

        #Making sure your designated ride values match your input ride values
        #Begin using accumulator variables
        try:
            for i in range (1, numberRides+1):
                rideMiles = float(dataDriver.readline().rstrip('\n'))
                rideMinutes = float(dataDriver.readline().rstrip('\n'))

                driverMiles += rideMiles
                driverMinutes += rideMinutes

                totalMiles += rideMiles
                totalMinutes += rideMinutes
                totalTrips += 1
        except:
            print("Non-numeric miles or minutes was found.")
            sys.exit()

        #call revenue function
        driverRevenue, totalRevenue = calculateRev(numberRides, driverMiles, driverMinutes, \
                                                   totalRevenue, BASEFARE, MILEFARE, MINFARE)
            
        #call average function
        driverAvgMiles, driverAvgMin, driverAvgRevenue = calculateAverage(driverMiles, \
                                                                          driverMinutes, \
                                                                          driverRevenue, \
                                                                          numberRides)
        #call output to file function
        output = outputToFile(OUTPUTFILE, driverId, carType, driverAvgMiles,\
                              driverAvgMin, driverAvgRevenue)
        
        driverId = dataDriver.readline().rstrip('\n')

    #Close file
    dataDriver.close()

    #Print summary
    print("Number of drivers processed:", totalDrivers)
    print("Total rides provided:", totalTrips)
    print("Total distance traveled:", round(totalMiles,1))
    print("Total mins taken:", str(format(int(totalMinutes),",.0f")))
    print("Total revenue: $" + format(totalRevenue,",.2f"))
    print("Output filename:", OUTPUTFILE)

#Function to calculate revenue
def calculateRev(numberRides, driverMiles, driverMinutes, totalRevenue, BASEFARE, MILEFARE, MINFARE):
    driverRevenue = (BASEFARE * numberRides) + (MILEFARE * driverMiles) + (MINFARE * driverMinutes)
    totalRevenue += driverRevenue
    return driverRevenue, totalRevenue

#Function to calculate average
def calculateAverage(driverMiles, driverMinutes,driverRevenue, numberRides):
    avgMiles = round(driverMiles/numberRides,1)
    avgMin = round(driverMinutes/numberRides,1)
    avgRevenue = round(driverRevenue/numberRides,2)
    return avgMiles, avgMin, avgRevenue

#Function to output to external file
def outputToFile(OUTPUTFILE, driverId, carType, avgMiles, avgMin, avgRevenue):
    summaryFile = open(OUTPUTFILE,'a')
    summary = driverId + " drives a " + carType + " and on average drove " + \
        str(avgMiles) + " miles for "+ str(avgMin) + " minutes and made $" + \
        format(avgRevenue,",.2f") + " per ride."
    summaryFile.write(summary + "\n")
    summaryFile.close()

main()
        
