using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalAssignment
{
    class Q1
    {
        /*          
         * Bryony Burniston
         * S00150642
         * 15 January 2015
         * 
         * Program Description:
         * Console Application will present user with a simple ATM menu.
         * User must first enter a PIN (constant 1357), if correct then user is shown a menu of options
         * 1. Withdraw 2. Balance 3.Change PIN 4.Quit
         * Program outputs relevant message for option chosen
         * Menu repeats until user chooses to Quit
         * 
         */

        //Main method
        static void Main(string[] args)
        {
            //Declare variables
            const int PIN = 1357;
            int enteredPin = 0;
            bool isCorrectPin = false;
            int option = 0;
            
            //Begin PIN while loop
            while(!isCorrectPin)//loop until correct pin entered
            {
                //Ask user for PIN
                Console.Write("Enter PIN >> ");

                //Check for valid entry i.e. a number
                while (!Int32.TryParse(Console.ReadLine(), out enteredPin))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                    Console.Write("Enter PIN >> ");
                }//while loop ends once a number has been entered
                
                //Check has user entered the correct PIN
                if (enteredPin != PIN)
                {
                    Console.WriteLine("Incorrect PIN entered!"); 
                }
                else
                {
                    isCorrectPin = true;                    
                }//end if else
            }//end PIN while loop

            //Begin Menu while loop
            while(option != 4)//loop until user chooses to Quit
            {
                //Present user with 4 options for bank menu
                Console.WriteLine("Please select from the options below");
                Console.WriteLine("1: Withdraw");
                Console.WriteLine("2: Balance");
                Console.WriteLine("3: Change PIN");
                Console.WriteLine("4: Quit");

                //Check for valid entry i.e. a number
                while (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Please enter a number 1-4!");
                }//while loop ends once a number has been entered
                
                //Switch statement to select output
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You selected Option 1 - \"Withdraw\"");
                        break;
                    case 2:
                        Console.WriteLine("You selected Option 2 - \"Balance\"");
                        break;
                    case 3:
                        Console.WriteLine("You selected Option 3 - \"Change PIN\"");
                        //Would call change PIN method here - not asked for in Question
                        break;
                    case 4:
                        Console.WriteLine("You selected Option 4 - \"Quit\". Please press enter to exit.");
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;

                }//end of Switch                
            }//End of Menu while loop

            //Pause program
            Console.ReadLine();

        }//end of main method 
    }//end of class
}
