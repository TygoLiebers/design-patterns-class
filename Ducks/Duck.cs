using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {

        private QuackBehavior? quackBehavior;
        private FlyBehavior? flyBehavior;
        private SwimBehavior? swimBehavior;
        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior?.Quack();
        }

        public void PerformFly()
        {
            flyBehavior?.Fly();
        }
        public void PreformSwim()
        {
            swimBehavior?.Swim();
        }

        public void SetFlyBehavior(FlyBehavior f) {
            flyBehavior = f;
        }

        public void SetQuackBehavior(QuackBehavior q)
        {
            quackBehavior = q;
        }

        public void SetSwimBehavior(SwimBehavior s)
        {
            swimBehavior = s;
        }
    }
}
