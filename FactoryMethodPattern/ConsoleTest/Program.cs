using System;
using FactoryMethod.Pattern.Factorys.Creaters;
using FactoryMethod.Pattern.Handlers;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new ProductHandler().ClientCode(new ConcreteCreator1());

            new ProductHandler().Main();
           // Console.WriteLine("Hello World!");
        }
    }
}
