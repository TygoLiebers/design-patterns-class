using DecoratorPattern.Beverages;

namespace DecoratorPattern.Stores
{
    internal abstract class CoffeeStore
    {
        public Beverage orderCoffee(string coffee)
        {
            Beverage b = CreateCoffee(coffee);
            if (b == null)
            {
                Console.WriteLine("We serve food here, sir");
                return b;
            }
            PrintBeverage(b);
            return b;
        }
        public abstract Beverage CreateCoffee(string coffeeName);

        public void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
