using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace KassaApp
{
   public class CashRegister
    {
        List<IProduct> products = new List<IProduct>();


        public void AddToReceipt(IProduct p)
        {
            products.Add(p);
        }

        public void PrintReceipt()
        {
            foreach(var p in products)
            {
                Console.WriteLine("Item: "+ p.Name);
                Console.WriteLine("Description: " + p.Description);
                Console.WriteLine("Price: " + p.Price);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Total price: " + SumReceipt());
        }

        public int SumReceipt()
        {
            return products.Sum(p => p.Price);
        }
    }
}
