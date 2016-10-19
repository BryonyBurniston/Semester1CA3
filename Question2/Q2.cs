using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Question2
{
    class Q2
    {
        /*          
         * Bryony Burniston
         * S00150642
         * 15 January 2015
         * 
         * Program Description:
         * Console Application will read product details from a file which has product number and number of units sold. 
         * Program will calculate total sales (price x units sold) and display the information
         * 
         */

        //Main method
        static void Main(string[] args)
        {
            //Declare variables
            const decimal P1_PRICE = 1.59m;
            const decimal P2_PRICE = 1.99m;
            const decimal P3_PRICE = 2.35m;
            string[] productDetail = new string[2];
            int[] numProductSold = new int[3];            
            decimal totalSales = 0;
                                   
            //Read information from file
            string[] productDetails = File.ReadAllLines(@"C:\Users\User\Dropbox\Bryony_Burniston_s00150642_Programming\S00150642BryonyBurnistonCA3\Question2\Data\ProductDetails.txt");

            //Save relevant information to array
            for (int i = 0; i < productDetails.Length; i++)
            {
                productDetail = productDetails[i].Split(',');
                //Console.WriteLine(productDetail[1]);
                numProductSold[i] = Convert.ToInt32(productDetail[1]);
                //Console.WriteLine(numProductSold[i]);
            }

            //Calculate total sales
            totalSales = (P1_PRICE * numProductSold[0]) + (P2_PRICE * numProductSold[1]) + (P3_PRICE * numProductSold[2]);
            
            //Display total sales
            Console.WriteLine("Total sales of all products amounts to {0:F}EURO", totalSales);
                        
            //Pause program
            Console.ReadLine();

        }//end of main method 
    }//end of class
    
}
