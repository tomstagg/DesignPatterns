using System;

namespace StrategyPattern
{
    public interface IQuackBehaviour
    {
        void Quack();
    }


    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}