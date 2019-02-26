using System;

namespace FactoryPattern
{
    public class PizzaStore
    {
        SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(String type)
        {
            Pizza pizza;

            pizza = _factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
