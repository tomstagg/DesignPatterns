using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaFactory = new SimplePizzaFactory();
            var pizzaStore = new PizzaStore(pizzaFactory);

            pizzaStore.OrderPizza("Cheese");
            pizzaStore.OrderPizza("Veggie");
        }
    }
}
