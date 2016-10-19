using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question4
{
    class Q4
    {
        /*          
         * Bryony Burniston
         * S00150642
         * 15 January 2015
         * 
         * Program Description:
         * Console Application that uses a 2D array to store given information, 
         * iterates through the array to calculate average scores and outputs averages to console
         *  
         * 
         */

        //Main method
        static void Main(string[] args)
        {
            //2d array to store information
            int[,] scores = {
                                {4,4,3},//scores given by Simon Cowell
                                {5,4,2},//scores given by Louis Walsh
                                {4,3,4},//scores given by Sheryl Cole
                                {3,3,2}//scores given by Mel B
                            };

            //Variables to store total scores for each performer
            int benScore = 0;
            int fleurScore = 0;
            int andreaScore = 0;

            const int JUDGES = 4;

            //Iterate through array to get total score for each performer
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {                    
                    switch(j)
                    {
                        case 0:
                            benScore += scores[i, j];
                            break;
                        case 1:
                            fleurScore += scores[i, j];
                            break;
                        case 2:
                            andreaScore += scores[i, j];
                            break;
                        default:
                            break;
                    }//End switch                  
                    
                }//end inner loop
            }//end outer loop

            //Calculate average results and display for each performer
            Console.WriteLine("The average score for each performer is as follows");
            Console.WriteLine("Ben Haenow >> {0}", benScore / JUDGES);
            Console.WriteLine("Fleur East >> {0}", fleurScore / JUDGES);
            Console.WriteLine("Andrea Faustini >> {0}", andreaScore / JUDGES);              
            
            //Pause program
            Console.ReadLine();

        }//End of main method
    }//End of class
}
