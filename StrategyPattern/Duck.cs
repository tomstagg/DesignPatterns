using System;

namespace StrategyPattern
{
    abstract public class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;

        public void Swim()
        {
            Console.WriteLine("All ducks can swim");
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehaviour.fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void SetFlyBehaviour(IFlyBehaviour newflyBehaviour)
        {
            flyBehaviour = newflyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour newquackBehaviour)
        {
            quackBehaviour = newquackBehaviour;
        }

    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }

    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Squeak();
        }
        public override void Display()
        {
            System.Console.WriteLine("I'm a rubber duck");
        }
    }
}
