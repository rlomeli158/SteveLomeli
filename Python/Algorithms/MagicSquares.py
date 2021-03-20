#  File: MagicSquares.py
#  Description: Create a magic square
#  Student's Name: Steve Lomeli
#  Student's UT EID: srl2629
#  Course Name: CS 303E 
#  Unique Number: 50180
#
#  Date Created: 4/16/2020
#  Date Last Modified: 4/20/2020

import numpy as np

class MagicSquare:

    def __init__(self, side):
        self.sideLength = side
        self.grid = []

        #Set counter as one, we'll use this to measure progress to side**2
        counter = 1

        #Create list of side length filled with zeroes
        self.magic_square = np.zeros((self.sideLength,self.sideLength), dtype=int)

        #Set starting point
        i, j = 0, self.sideLength//2

        #Loop to find next position, accumulate until counter reaches side squared
        while counter <= self.sideLength**2:
            self.magic_square[i, j] = counter
            counter += 1
            newi, newj = (i-1) % self.sideLength, (j+1)% self.sideLength
            if self.magic_square[newi, newj]:
                i += 1
            else:
                i, j = newi, newj
        
    #Print in a formatted manner without the []'s 
    def prettyPrint(self):
        numRows = self.sideLength
        numCols = self.sideLength

        for row in range(numRows):
            for col in range(numCols):
                print(format(self.magic_square[row, col],"5d"),end="")
            print("")
        return ""

def main():

    #Iterate for odd numbers from 1 to right before 14 and create a magic square
    for i in range(1,14,2):
        square = MagicSquare(i)
        print("Magic square of size", i)
        print(square.prettyPrint())

main()
