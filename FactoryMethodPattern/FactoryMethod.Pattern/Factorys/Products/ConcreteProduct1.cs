using FactoryMethod.Pattern.Factorys.Interfaces;

namespace FactoryMethod.Pattern.Factorys.Products
{
    class ConcreteProduct1 : IProductFactory
    {
        public string Operation()
        {
            return "Product 1 Created";
        }
    }
}
