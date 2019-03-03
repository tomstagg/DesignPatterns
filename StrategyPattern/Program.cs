using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck rubberDuck = new RubberDuck();

            PerformDuck(mallardDuck);
            PerformDuck(rubberDuck);
            rubberDuck.SetFlyBehaviour(new FlyRocketPowered());
            PerformDuck(rubberDuck);

        }

        static void PerformDuck(Duck duck)
        {
            duck.Display();
            duck.Swim();
            duck.PerformFly();
            duck.PerformQuack();
            System.Console.WriteLine();
        }
    }



}
