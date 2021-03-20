using FinalProjectWorkspace.DAL;
using System;
using System.Linq;


namespace FinalProjectWorkspace.Utilities
{
    public static class GenerateNextMovieNumber
    {
        public static Int32 GetNextMovieNumber(AppDbContext _context)
        {
            //set a constant to designate where the order numbers 
            //should start
            const Int32 START_NUMBER = 3000;

            Int32 intMaxMovieNumber; //the current maximum order number
            Int32 intNextMovieNumber; //the order number for the next class

            if (_context.Movies.Count() == 0) //there are no movies in the database yet
            {
                intMaxMovieNumber = START_NUMBER; //order numbers start at 3001
            }
            else
            {
                intMaxMovieNumber = _context.Movies.Max(c => c.MovieNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxMovieNumber < START_NUMBER)
            {
                intMaxMovieNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextMovieNumber = intMaxMovieNumber + 1;

            //return the value
            return intNextMovieNumber; //Might have to change this to string depending on ID data type
        }

    }
}

/******************
 * 
 * TO ACTUALLY ASSIGN THE CUSTOMER ID PULLED FROM HW 5
 * //Set order number automatically
   order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

I think that it would be something like
Id = Utilities.GenerateNextCustomerID.GetNextCustomerID(_context);
 * 
 * 
 */
