using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question5
{
    class Client
    {
        /*          
        * Bryony Burniston
        * S00150642
        * 15 January 2015
        * 
        * Client class has 2 properties, Name and Phone Number and a method, DisplayDetails which outputs 
        * the name and number to console.  
        * 
        */

        //Properties
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        //Constructor
        public Client(string name, int number)
        {
            Name = name;
            PhoneNumber = number;
        }

        //Method to output name and number to console
        public void DisplayDetails()
        {
            Console.WriteLine("Client Name: {0}, Phone Number: {1}", Name, PhoneNumber);
        }
    }
}
