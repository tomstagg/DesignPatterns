namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => _beverage.Description + ", Mocha";

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => _beverage.Description + ", Whip";

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
