using FinalProjectWorkspace.DAL;
using System;
using System.Linq;


namespace FinalProjectWorkspace.Utilities
{
    public static class GenerateNextTransactionNumber
    {
        public static Int32 GetNextTransactionNumber(AppDbContext _context)
        {
            //set a constant to designate where the order numbers 
            //should start
            const Int32 START_NUMBER = 10000;

            Int32 intMaxTransactionNumber; //the current maximum order number
            Int32 intNextTransactionNumber; //the order number for the next class

            if (_context.Order.Count() == 0) //there are no orders in the database yet
            {
                intMaxTransactionNumber = START_NUMBER; //order numbers start at 70001
            }
            else
            {
                intMaxTransactionNumber = _context.Order.Max(c => c.TransactionNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxTransactionNumber < START_NUMBER)
            {
                intMaxTransactionNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextTransactionNumber = intMaxTransactionNumber + 1;

            //return the value
            return intNextTransactionNumber;
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
