using FactoryMethod.Pattern.Factorys.Creaters;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Pattern.Handlers
{
    public class ProductHandler
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public CreatorBasicProduct ClientCode(CreatorBasicProduct creator)
        {
            Console.WriteLine("Retorna: EntidadeCriada. " + creator.);
            return creator;
            // ...
        }
    }
}
