using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Factory
            var abstractFactory = new AbstractFactoryPattern();
            abstractFactory.Run();

            // Singeloton
            var singleton = new SingletonPattern();
            singleton.Run();

            // Factory Method
            var factoryMethod = new FactoryMethodPattern();
            factoryMethod.Run();

            // Builder Method
            var builder = new BuilderPattern();
            builder.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}
