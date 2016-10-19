using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question3
{
    class Q3
    {
        /*          
         * Bryony Burniston
         * S00150642
         * 15 January 2015
         * 
         * Program Description:
         * Console Application that uses a method which takes in two dates and calculates number of days between them as an integer
         * 
         */

        //Main method
        static void Main(string[] args)
        {
            //Date variables - could extend program to ask user to enter dates
            DateTime date1 = new DateTime(2013, 12, 31);
            DateTime date2 = new DateTime(2014, 12, 31);

            //Output information to console, using NumberOfDays method
            Console.WriteLine("There are {0} days between {1:d/M/yyyy} and {2:d/M/yyyy}", NumberOfDays(date1, date2), date1, date2);

            //Pause program
            Console.ReadLine();

        }//End of main method

        //Method to calculate number of days between two given dates
        static int NumberOfDays(DateTime date1, DateTime date2)
        {
            //Declare variables
            int numDays = (date2 - date1).Days;

            //Return value
            return numDays;
        }//End of NumberOfDays method
                       
    }//End of class
}
