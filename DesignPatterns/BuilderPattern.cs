using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BuilderPattern
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create director and builders
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();
            // Construct two products
            director.Construct(b1);
            ProductForBuilder p1 = b1.GetResult();
            p1.Show();
            director.Construct(b2);
            ProductForBuilder p2 = b2.GetResult();
            p2.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'Director' class
    /// </summary>
    class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract ProductForBuilder GetResult();
    }
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class ConcreteBuilder1 : Builder
    {
        private ProductForBuilder _product = new ProductForBuilder();
        public override void BuildPartA()
        {
            _product.Add("PartA");
        }
        public override void BuildPartB()
        {
            _product.Add("PartB");
        }
        public override ProductForBuilder GetResult()
        {
            return _product;
        }
    }
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class ConcreteBuilder2 : Builder
    {
        private ProductForBuilder _product = new ProductForBuilder();
        public override void BuildPartA()
        {
            _product.Add("PartX");
        }
        public override void BuildPartB()
        {
            _product.Add("PartY");
        }
        public override ProductForBuilder GetResult()
        {
            return _product;
        }
    }
    /// <summary>
    /// The 'ProductForBuilder' class
    /// </summary>
    class ProductForBuilder
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}
