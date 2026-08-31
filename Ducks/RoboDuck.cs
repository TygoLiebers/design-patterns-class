using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class RoboDuck : Duck
    {
        public RoboDuck()
        {
            quackBehavior = new RegularQuack();
            flyBehavior = new FlyWithWings();
            swimBehavior = new Sink();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robo Duck");
        }
    }
}
