using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Question6
{
    class Q6
    {
        /*          
         * Bryony Burniston
         * S00150642
         * 15 January 2015
         * 
         * Program Description:
         * Console Application that reads in product information from one file and sales information from another,
         * making use of a Product Class.
         * 
         * Program will read product information and create Product objects using this information, storing them in a list
         * Then sales information will be read and Product properties updated, information displayed to screen.
         * Finally updated Product information is written to a file.
         * 
         * Algorithm:
         * 1. Read product information from file, creating Product objects
         *      1a.Ascertain file location to be used
         *      1b.Create a list to store Product objects
         *      1c.Split up each line of information in file (comma delimiter)
         *      1d.Create one Product object per line of information in file
         * 2. Read sales information from file and update Products
         *      2a.Ascertain file location to be used
         *      2b.Split up each line of information in file (comma delimiter)
         *      2c.Update each Product object with new information
         * 3. Display Product details and sales information
         *      3a.Headings
         *      3b.Product information - format output
         *      3c.Total Saleso
         * 4. Write updated Poduct information to a file
         *      4a.Ascertain file location to be used
         *      4b.Format each products information for writing to file
         *      4c.Write to file
         * 
         */

        //Main method
        static void Main(string[] args)
        {          
           
            //Read in data from product file, creating a list of Product objects
            List<Product> products = ReadProductFile();      
            
            //Read in data from sales file and update products list
            UpdateSales(products);

            //Display sales information to console
            DisplayProduct(products);

            //Write updated Product information to file
            WriteToFile(products);
            
            //Pause program
            Console.ReadLine();

        }//End of main method

        //Method to get filepath for Data directory based on current working directory
        private static string GetDataDirectory()
        {
            string dir = Directory.GetCurrentDirectory();
            int cut = dir.IndexOf("bin");
            string filepath = dir.Remove(cut) + "Data\\";
            return filepath;

        }//End of GetDataDirectory method

        //Method to read file and create a list of Product objects with the information
        private static List<Product> ReadProductFile()
        {
            //List of Products to be returned
            List<Product> productList = new List<Product>();

            //Location of file
            string file = GetDataDirectory() + "productdetails.csv";
                        
            //Store file information
            string[] productDetails = File.ReadAllLines(file);
            string[] productDetail = new string[5];

            //Split up details for use
            for (int i = 0; i < productDetails.Length; i++)
            {
                productDetail = productDetails[i].Split(',');
                
                //Create Product and add to List
                Product newProduct = new Product(productDetail[0], productDetail[1], productDetail[2],Convert.ToDecimal(productDetail[3]), Convert.ToInt32(productDetail[4]));
                productList.Add(newProduct);             
            }
            
            return productList;

        }//End of ReadProductFile method        

        //Method to read in sales file and update products list
        private static void UpdateSales(List<Product> products)
        {
            //Location of file
            string file = GetDataDirectory() + "salesdata.csv";

            //Store file information
            string[] salesDetails = File.ReadAllLines(file);
            string[] salesDetail = new string[2];

            //Split up details for use
            for (int i = 0; i < salesDetails.Length; i++)
            {
                salesDetail = salesDetails[i].Split(',');

                //Update Products
                foreach (Product product in products)
                {
                    if (salesDetail[0] == product.ID)
                    {
                        //update WeeklySales, StockAvailable and Total properties
                        product.RecordSales(Convert.ToInt32(salesDetail[1]));                        
                    }                    
                }                
            }

        }//End of UpdateSales method

        //Method to display sales information
        private static void DisplayProduct(List<Product> products)
        {
            decimal totalSales = 0;
            //Headings
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10}", "ID", "Name", "Price", "Sales", "Total", "Stock");

            //Product information displayed
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
                totalSales += product.Total;
            }

            Console.WriteLine("\nTotal Sales for the week are {0:F}", totalSales);

        }//End of DisplayProduct method

        //Method to write updated product information to file
        private static void WriteToFile(List<Product> products)
        {
            //Location of file
            string file = GetDataDirectory() + "updatedproductdetails.csv";                         
            
            //Variables to store details of each product
            string productDetails = "";
            string fileContent = "";

            //Go through list of Products writing details to file
            foreach (Product product in products)
            {
                //Format Product details ready for writing to file
                productDetails = product.FileFormat();
                fileContent += productDetails;                
            }
            //Write information to file, overwriting any previous content
            File.WriteAllText(file, fileContent);

        }//End of WriteToFile method

    }//End of class
}