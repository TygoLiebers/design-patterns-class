using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck roboDuck = new RoboDuck();

            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.PreformSwim();
            Console.WriteLine();

            redheadDuck.Display();
            redheadDuck.PerformFly();
            redheadDuck.PerformQuack();
            redheadDuck.PreformSwim();
            Console.WriteLine();

            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            decoyDuck.PreformSwim();
            Console.WriteLine();

            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            rubberDuck.PreformSwim();
            Console.WriteLine();

            roboDuck.Display();
            roboDuck.PerformFly();
            roboDuck.PerformQuack();
            roboDuck.PreformSwim();
        }
    }
}