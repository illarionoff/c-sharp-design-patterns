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

            // Decorator
            var decorator = new DecoratorPattern();
            decorator.Run();

            // Facade
            var facade = new FacadePattern();
            facade.Run();

            // Mediator
            var mediator = new Mediator();
            mediator.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}
