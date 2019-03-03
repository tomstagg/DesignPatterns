using System;

namespace StrategyPattern
{
    public interface IFlyBehaviour
    {
        void fly();
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    class FlyRocketPowered : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with rocket power!");
        }
    }

    public class FlyWithWings : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}