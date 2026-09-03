using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class RoboDuck : Duck
    {
        public RoboDuck()
        {
            SetQuackBehavior(new RegularQuack());
            SetFlyBehavior(new FlyWithWings());
            SetSwimBehavior(new Sink());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robo Duck");
        }
    }
}
