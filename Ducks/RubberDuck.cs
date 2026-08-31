using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
