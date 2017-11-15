using System;
using System.Collections.Generic;
using System.Text;

namespace KassaApp.Products
{
    public class Banana : IProduct
    {
        public string Name { get { return "Banana"; } }
        public int Price { get { return 2; } }

        public string Description { get { return "Yellow"; } }
    }
}

