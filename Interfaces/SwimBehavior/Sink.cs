namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class Sink : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Im Sinking!");
        }
    }
}
