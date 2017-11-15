using System;
using System.Collections.Generic;
using System.Text;

namespace KassaApp.Products
{
    public class Strawberry : IProduct
    {
        public string Name { get { return "Strawberry"; } }
        public int Price { get { return 3; } }

        public string Description { get { return "Red"; } }
    }
}