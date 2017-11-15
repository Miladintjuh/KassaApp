using System;
using System.Collections.Generic;
using System.Text;

namespace KassaApp
{
    public interface IProduct
    {
        string Name { get; }
        int Price { get; }
        string Description { get; }

        
    }
}
