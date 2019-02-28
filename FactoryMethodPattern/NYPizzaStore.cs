namespace FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            switch (pizzaType)
            {
                case "pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new NYStyleClamPizza();
                    break;

            }
            return pizza;
        }
    }
}
