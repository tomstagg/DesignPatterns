using System;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        abstract public string Name { get; }
        public virtual void Bake()
        {
            Console.WriteLine("Baking Pizza");
        }

        public virtual void Box()
        {
            Console.WriteLine("Boxing Pizza");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting Pizza");
        }

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name} pizza");
        }
    }
}
