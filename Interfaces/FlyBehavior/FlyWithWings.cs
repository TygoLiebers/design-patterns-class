namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal class FlyWithWings : FlyBehavior
    {
        public void Fly() {
            Console.WriteLine("Im flying using my wings!");
        }
    }
}
