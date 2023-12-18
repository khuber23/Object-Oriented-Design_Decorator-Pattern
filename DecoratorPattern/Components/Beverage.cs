namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected decimal cost;

        protected string description = "Unknown Beverage";

        public abstract decimal Cost { get; set; }

        public abstract string Description { get; set; }
    }
}