using System;
using System.Collections.Generic;
using System.Linq;

using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System.Text;

namespace FinalProjectWorkspace.Seeding
{
    public class SeedGenres
    {
        //You will call this method from the SeedController to add Genres
        public static void SeedAllGenres(AppDbContext db)
        {
            //create a list of Genres to add
            List<Genre> AllGenres = new List<Genre>();

            //create a new instance of the Genre class
            Genre c1 = new Genre() { GenreName = "Action" };
            //add the Genre to the list
            AllGenres.Add(c1);

            //create a new instance of the Genre class
            Genre c2 = new Genre() { GenreName = "Adventure" };
            //add the Genre to the list
            AllGenres.Add(c2);

            //create a new instance of the Genre class
            Genre c3 = new Genre() { GenreName = "Animation" };
            //add the Genre to the list
            AllGenres.Add(c3);

            //create a new instance of the Genre class
            Genre c4 = new Genre() { GenreName = "Comedy" };
            //add the Genre to the list
            AllGenres.Add(c4);

            //create a new instance of the Genre class
            Genre c5 = new Genre() { GenreName = "Crime" };
            //add the Genre to the list
            AllGenres.Add(c5);

            //create a new instance of the Genre class
            Genre c6 = new Genre() { GenreName = "Drama" };
            //add the Genre to the list
            AllGenres.Add(c6);

            //create a new instance of the Genre class
            Genre c7 = new Genre() { GenreName = "Family" };
            //add the Genre to the list
            AllGenres.Add(c7);

            //create a new instance of the Genre class
            Genre c8 = new Genre() { GenreName = "Fantasy" };
            //add the Genre to the list
            AllGenres.Add(c8);

            //create a new instance of the Genre class
            Genre c9 = new Genre() { GenreName = "Horror" };
            //add the Genre to the list
            AllGenres.Add(c9);

            //create a new instance of the Genre class
            Genre c10 = new Genre() { GenreName = "Musical" };
            //add the Genre to the list
            AllGenres.Add(c10);

            //create a new instance of the Genre class
            Genre c11 = new Genre() { GenreName = "Romance" };
            //add the Genre to the list
            AllGenres.Add(c11);

            //create a new instance of the Genre class
            Genre c12 = new Genre() { GenreName = "Science Fiction" };
            //add the Genre to the list
            AllGenres.Add(c12);

            //create a new instance of the Genre class
            Genre c13 = new Genre() { GenreName = "Thriller" };
            //add the Genre to the list
            AllGenres.Add(c13);

            //create a new instance of the Genre class
            Genre c14 = new Genre() { GenreName = "War" };
            //add the Genre to the list
            AllGenres.Add(c14);

            //create a new instance of the Genre class
            Genre c15 = new Genre() { GenreName = "Western" };
            //add the Genre to the list
            AllGenres.Add(c15);

            //create a counter and flag to help with debugging
            int intGenreID = 0;
            String strGenreName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Genres
                foreach (Genre seedGenre in AllGenres)
                {
                    //updates the counters to get info on where the problem is
                    intGenreID = seedGenre.GenreID;
                    strGenreName = seedGenre.GenreName;

                    //try to find the Genre in the database
                    Genre dbGenre = db.Genres.FirstOrDefault(c => c.GenreName == seedGenre.GenreName);

                    //if the Genre isn't in the database, dbCategory will be null
                    if (dbGenre == null)
                    {
                        //add the Genre to the database
                        db.Genres.Add(seedGenre);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for Genre because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbGenre.GenreName = seedGenre.GenreName;
                        //you would add other fields here
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
                msg.Append(strGenreName);
                msg.Append(" Genre (GenreID = ");
                msg.Append(intGenreID);
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
