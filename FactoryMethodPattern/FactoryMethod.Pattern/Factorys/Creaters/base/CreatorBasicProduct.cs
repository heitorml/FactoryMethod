using FactoryMethod.Pattern.Factorys.Interfaces;

namespace FactoryMethod.Pattern.Factorys.Creaters
{
    public abstract class CreatorBasicProduct
    {
        public abstract IProductFactory FactoryMethod();

        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }
}
