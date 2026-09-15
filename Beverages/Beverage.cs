namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
