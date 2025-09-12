// HW1a Sales Total

// Your Name: Ryan McCarthy 
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string ItemName =Console.ReadLine();
            Console.WriteLine("How many items did you want to buy?"); 
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the price for each item?");
            double price = Convert.ToDouble(Console.ReadLine());

            const double multiplier = .085;

            double subtotal = quantity * price;
            double salestax= price* quantity * multiplier;
            double total= subtotal+salestax;  

            Console.WriteLine("Your subtotal for your bill is "+ subtotal);
            Console.WriteLine("Your sales tax for your bill is "+salestax);
            Console.WriteLine("Your total for your bill is "+total);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
