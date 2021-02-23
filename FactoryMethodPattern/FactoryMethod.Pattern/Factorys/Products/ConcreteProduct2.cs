using FactoryMethod.Pattern.Factorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Pattern.Factorys.Products
{
    class ConcreteProduct2 : IProductFactory
    {
        public string Operation()
        {
            return "Product 2 created";
        }
    }
}
