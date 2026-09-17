using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Whisky : CondimentDecorator
    {
        public Whisky(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 0.35 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Whisky";
        }
    }
}
