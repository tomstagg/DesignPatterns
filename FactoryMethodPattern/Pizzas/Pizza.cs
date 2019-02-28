using System;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        protected string test;
        abstract protected string Name { get; }
        abstract protected string Dough { get; }
        abstract protected string Sauce { get; }


        internal void Bake()
        {
            Console.WriteLine("Bake for 25 mins at 200C");
        }

        internal void Box()
        {
            Console.WriteLine("Place pizza in offical PizzaStore box");
        }

        internal void Cut()
        {
            Console.WriteLine("Cutting pizza into triangular slices");
        }

        internal void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing {Dough}...");
            Console.WriteLine($"Adding {Sauce}...");
        }
    }
}
