namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Expresso();

            coffee.Details();
            coffee = new Mocha(coffee);
            coffee = new Mocha(coffee);
            coffee.Details();
            coffee = new Whip(coffee);
            coffee.Details();
        }
    }




}
