namespace FactoryMethodPattern
{
    internal class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            test = "123";
        }
        protected override string Name => "NY Style Sauce and Pepperoni Pizza";

        protected override string Dough => "Thin Crust Dough";

        protected override string Sauce => "Marinara Sauce";
    }
}
