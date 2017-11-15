using KassaApp.Products;
using System;

namespace KassaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr = new CashRegister();

            cr.AddToReceipt(new Banana());
            cr.AddToReceipt(new Strawberry());

            cr.PrintReceipt();
            

            Console.ReadLine();
        }
    }
}
