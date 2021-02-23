using FactoryMethod.Pattern.Factorys.Interfaces;
using FactoryMethod.Pattern.Factorys.Products;

namespace FactoryMethod.Pattern.Factorys.Creaters
{
    public class ConcreteCreator2 : CreatorBasicProduct
    {
        public override IProductFactory FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
