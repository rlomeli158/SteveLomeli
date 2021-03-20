#  File: GuessingGame.py
#  Description: Guess a number
#  Student's Name: Steve Lomeli
#  Student's UT EID: srl2629
#  Course Name: CS 303E 
#  Unique Number: 50180
#
#  Date Created: 2/23/2020
#  Date Last Modified: 2/23/2020

import sys

def main():

    #Assign variables
    secretNumber = int(1458)
    attempts = 0

    #Ask for first guess
    print("Welcome to the guessing game.  You have ten tries to guess my number.")
    guess = int(input("Please enter your guess: "))

    #Validate first guess
    while guess < 0 or guess > 10000:
        print("Your guess must be between 0001 and 9999.")
        guess = int(input("Please enter a valid guess: "))

    #Add 1 to attempt counter
    attempts +=1

    #Loop for attempts
    while attempts < 10:

        #Loop if guess is low
        while guess < secretNumber and attempts < 10:
            print("Your guess is too low.")
            print("Guesses so far:", attempts)
            guess = int(input("Please enter your guess: "))

            #Validate
            while guess < 0 or guess > 10000:
                print("Your guess must be between 0001 and 9999.")
                guess = int(input("Please enter a valid guess: "))

            #Counter
            attempts += 1

            #If attempts are met
            if attempts == 10:
                print("Your guess is too low.")
                print("Guesses so far:", attempts)
                print("Game over: you ran out of guesses.")
                break

        #Loop if guess is high
        while guess > secretNumber and attempts < 10:
            print("Your guess is too high.")
            print("Guesses so far:", attempts)
            guess = int(input("Please enter your guess: "))

            #Validate
            while guess < 0 or guess > 10000:
                print("Your guess must be between 0001 and 9999.")
                guess = int(input("Please enter a valid guess: "))

            #Counter
            attempts += 1

            #If attempts are met
            if attempts == 10:
                print("Your guess is too high.")
                print("Guesses so far:", attempts)
                print("Game over: you ran out of guesses.")
                break

        #Loop if number is correct in allotted attempts
        while guess == secretNumber and attempts <= 10:

            #If on first try
            if attempts == 1:
                print("That's correct!\
                        \nCongratulations! You guessed it on the first try!")
                sys.exit()

            #Otherwise
            else:
                print("That's correct!\
                        \nCongratulations! You guessed it in", attempts,"guesses.")
                sys.exit()

main()
