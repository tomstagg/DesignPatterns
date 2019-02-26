namespace FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "Cheese":
                    pizza =  new CheesePizza();
                    break;
                case "Veggie":
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
