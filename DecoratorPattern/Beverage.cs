using System;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract string Description {get; }
        public abstract double Cost();

        public void Details()
        {
            Console.WriteLine($"{Description} cost: {Cost()}");
        }
    }

    public class Expresso : Beverage
    {
        public override string Description => "Expresso";

        public override double Cost()
        {
            return 1.99;
        }
    }
}
