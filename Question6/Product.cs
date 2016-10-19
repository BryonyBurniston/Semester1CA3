using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question6
{
    /*          
        * Bryony Burniston
        * S00150642
        * 15 January 2015
        * 
        * Program Description:
        * Product Class with properties: ID, Name, Description, Price, Stock Available, Weekly Sales
        * Class will have 3 methods: ToString, FileFormat, RecordSales
        * 
        */

    class Product
    {       
        //Class properties
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockAvailable { get; set; }
        public int WeeklySales { get; set; }
        public decimal Total { get; set; }
        
        //Constructor
        public Product(string id, string name, string description, decimal price, int stock)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            StockAvailable = stock;            
        }

        //Method to format output of Product details
        public override string ToString()
        {
            return String.Format("{0,-10} {1,-20} {2,-10:F} {3,-10} {4,-10:F} {5,-10}", ID, Name, Price, WeeklySales, Total, StockAvailable);
             
        }//End of ToString method

        //Method to format Product information for writing to file
        public string FileFormat()
        {
            return String.Format("{0},{1},{2},{3},{4}\n", ID, Name, Description, Price, StockAvailable);
        }//End of FileFormat method

        //Method to update WeeklySales, StockAvailable and Total properties
        public void RecordSales(int sales)
        {
            WeeklySales = sales;
            StockAvailable -= sales;
            Total = Price * WeeklySales;
        }//End of RecordSales method

    }//End of Product Class
}
