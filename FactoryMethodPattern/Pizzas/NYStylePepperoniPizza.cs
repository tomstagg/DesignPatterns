namespace FactoryMethodPattern
{
    internal class NYStylePepperoniPizza : Pizza
    {
        protected override string Name => "NY Style Sauce and Pepperoni Pizza";

        protected override string Dough => "Thin Crust Dough";

        protected override string Sauce => "Marinara Sauce";
    }
}
