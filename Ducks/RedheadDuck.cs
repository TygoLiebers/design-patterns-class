using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new RegularQuack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
