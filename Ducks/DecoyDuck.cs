using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Ducks
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
