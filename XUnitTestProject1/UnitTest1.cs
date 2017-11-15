using System;
using Xunit;
using KassaApp;
using KassaApp.Products;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            CashRegister cr = new CashRegister();
            cr.AddToReceipt(new Banana());
            cr.AddToReceipt(new Strawberry());
            int expected = 5;
            int actual = cr.SumReceipt();

            Assert.Equal(expected, actual);
        }
    }
}
