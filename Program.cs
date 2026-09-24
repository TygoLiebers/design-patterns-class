using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Stores;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeStore c = new StarbuzzCoffee();
            c.orderCoffee("Espresso");
            c.orderCoffee("Doppio");
            c.orderCoffee("Lungo");
            c.orderCoffee("Macchiato");
            c.orderCoffee("Corretta");
            c.orderCoffee("ConPanna");
            c.orderCoffee("Cuppachinno");
            c.orderCoffee("Americano");
            c.orderCoffee("CaffeLatte");
            c.orderCoffee("FlatWhite");
            c.orderCoffee("Romana");
            c.orderCoffee("Morocchino");
            c.orderCoffee("Mocha");
            c.orderCoffee("Bicerin");
            c.orderCoffee("Breve");
            c.orderCoffee("RafCoffee");
            c.orderCoffee("MeadRaf");
            c.orderCoffee("Galao");
            c.orderCoffee("CaffeAffogato");
            c.orderCoffee("ViennaCoffee");
            c.orderCoffee("Glace");
            c.orderCoffee("ChocolateMilk");
            c.orderCoffee("DemiCreme");
            c.orderCoffee("LatteMacchiato");
            c.orderCoffee("Freddo");
            c.orderCoffee("Frappuccino");
            c.orderCoffee("CaramelFrappuccino");
            c.orderCoffee("Frappe");
            c.orderCoffee("IrishCoffee");
        }
    }
}