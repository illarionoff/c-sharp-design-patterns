using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DecoratorPattern
    {
        public void Run()
        {
            var gigantosaurus = new Gigantosaurus();

            Console.WriteLine(gigantosaurus.Roar());

            var loudGigantosaurus = new LoudGigantosarusDecorator(gigantosaurus);
            var extraLoudGigantosaurus = new ExtraLoudGigantosaurusDecorator(loudGigantosaurus);

            Console.WriteLine(extraLoudGigantosaurus.Roar());
        }
    }

    public interface IGigantosaurus
    {
        string Roar();
    }

    // Interface implementation
    public class Gigantosaurus : IGigantosaurus
    {
        public string Roar()
        {
            return "ROAR";
        }

    }

    // First decorator
    public class LoudGigantosarusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public LoudGigantosarusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{this.gigantosaurus.Roar()} loudly";
        }
    }

    // Second decorator
    public class ExtraLoudGigantosaurusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{this.gigantosaurus.Roar()}!";
        }
    }

    // Third decorator
    public class SilentGigantosaurusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public SilentGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return "";
        }
    }
}
