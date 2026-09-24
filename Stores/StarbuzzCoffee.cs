using System.Linq.Expressions;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Stores
{
    internal class StarbuzzCoffee : CoffeeStore
    {
        public override Beverage CreateCoffee(string coffeeName) {
            Beverage beverage = null;
            switch (coffeeName)
            {
                case "Espresso":
                    beverage = new Espresso();
                    break;
                case "Doppio":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    break;
                case "Lungo":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    break;
                case "Macchiato":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    break;
                case "Corretta":
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    break;
                case "ConPanna":
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    break;
                case "Cuppachinno":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "Americano":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;
                case "CaffeLatte":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "FlatWhite":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;
                case "Romana":
                    beverage = new Espresso();
                    beverage = new Lemon(beverage);
                    break;
                case "Morocchino":
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "Mocha":
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "Bicerin":
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "Breve":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;
                case "RafCoffee":
                    beverage = new Espresso();
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    break;
                case "MeadRaf":
                    beverage = new Espresso();
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;
                case "Galao":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "CaffeAffogato":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case "ViennaCoffee":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "Glace":
                    beverage = new Espresso();
                    beverage = new IceCream(beverage);
                    break;
                case "ChocolateMilk":
                    beverage = new Chocolate();
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;
                case "DemiCreme":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;
                case "LatteMacchiato":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "Freddo":
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    beverage = new Ice(beverage);
                    break;
                case "Frappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "CaramelFrappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;
                case "Frappe":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case "IrishCoffee":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whisky(beverage);
                    beverage = new Whip(beverage);
                    break;
                default:
                    break;
            }              
            return beverage;
        }
    }
}
