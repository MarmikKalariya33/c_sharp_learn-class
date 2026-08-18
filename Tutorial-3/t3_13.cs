using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    internal class t3_13
    {
        // Properties
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public static void product()
        {
            t3_13 obj = new t3_13();

            // Accept product details
            Console.Write("Enter Product ID: ");
            obj.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            obj.ProductName = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            obj.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            obj.Quantity = Convert.ToInt32(Console.ReadLine());

            // Calculate bill amount
            double billAmount = obj.Price * obj.Quantity;

            // Display product details and bill
            Console.WriteLine("\n========== PRODUCT BILL ==========");
            Console.WriteLine("Product ID     : " + obj.ProductId);
            Console.WriteLine("Product Name   : " + obj.ProductName);
            Console.WriteLine("Price          : " + obj.Price);
            Console.WriteLine("Quantity       : " + obj.Quantity);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Bill Amount    : " + billAmount);
        }
    }
}