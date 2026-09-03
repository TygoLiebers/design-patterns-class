using StrategyPattern.Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = [new MallardDuck(), new RedheadDuck(), new DecoyDuck(), new RubberDuck(), new RoboDuck()];

            foreach (Duck duck in ducks) {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                duck.PreformSwim();
                Console.WriteLine();
            }
        }
    }
}