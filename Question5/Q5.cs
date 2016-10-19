using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question5
{
    class Q5
    {
        /*          
         * Bryony Burniston
         * S00150642
         * 15 January 2015
         * 
         * Program Description:
         * Two clients to be created and call the DisplayDetails method on each.
         *  
         * 
         */

        //Main method
        static void Main(string[] args)
        {
            Client sally = new Client("Sally Jones", 2985736);
            Client george = new Client("George Granger", 37625678);

            sally.DisplayDetails();
            george.DisplayDetails();


            //Pause program
            Console.ReadLine();
        }
    }
}
