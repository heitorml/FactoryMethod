using FactoryMethod.Pattern.Factorys.Interfaces;
using FactoryMethod.Pattern.Factorys.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Pattern.Factorys.Creaters
{
    public class ConcreteCreator1 : CreatorBasicProduct
    {
        public override IProductFactory FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
