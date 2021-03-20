using System;
using System.Collections.Generic;
using System.Linq;

using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System.Text;

namespace FinalProjectWorkspace.Seeding
{
    public class SeedPrices
    {
        //You will call this method from the SeedController to add Price
        public static void SeedAllPrices(AppDbContext db)
        {
            //create a list of Price to add
            List<Price> AllPrices = new List<Price>();

            //create a new instance of the Price class
            Price c1 = new Price() { PriceName = "MATINEE_PRICE", PriceAmount = 5.00m};
            //add the Price to the list
            AllPrices.Add(c1);

            //create a new instance of the Price class
            Price c2 = new Price() { PriceName = "DISCOUNT_TUESDAY_PRICE", PriceAmount = 8.00m };
            //add the Price to the list
            AllPrices.Add(c2);

            //create a new instance of the Price class
            Price c3 = new Price() { PriceName = "WEEKDAY_REGULAR_PRICE", PriceAmount = 10.00m };
            //add the Price to the list
            AllPrices.Add(c3);

            //create a new instance of the Price class
            Price c4 = new Price() { PriceName = "WEEKEND_REGULAR_PRICE", PriceAmount = 12.00m };
            //add the Price to the list
            AllPrices.Add(c4);

            //create a new instance of the Price class
            Price c5 = new Price() { PriceName = "SPECIAL_EVENT_PRICE", PriceAmount = 12.00m };
            //add the Price to the list
            AllPrices.Add(c5);

            //create a new instance of the Price class
            Price c6 = new Price() { PriceName = "SENIOR_DISCOUNT", PriceAmount = 2.00m };
            //add the Price to the list
            AllPrices.Add(c6);

            //create a counter and flag to help with debugging
            int intPriceID = 0;
            String strPriceName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Genres
                foreach (Price seedPrice in AllPrices)
                {
                    //updates the counters to get info on where the problem is
                    intPriceID = seedPrice.PriceID;
                    strPriceName = seedPrice.PriceName;

                    //try to find the Genre in the database
                    Price dbPrice = db.Prices.FirstOrDefault(p => p.PriceName == seedPrice.PriceName);

                    //if the Price isn't in the database, dbPrice will be null
                    if (dbPrice == null)
                    {
                        //add the Genre to the database
                        db.Prices.Add(seedPrice);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        dbPrice.PriceName = seedPrice.PriceName;
                        dbPrice.PriceAmount = seedPrice.PriceAmount;
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)  //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append(strPriceName);
                msg.Append(" Price (PriceID = ");
                msg.Append(intPriceID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above.  The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }

    }
}
