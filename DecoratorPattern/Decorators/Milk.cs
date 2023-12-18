using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    public class Milk : CondimentDecorator
    {
        public Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description += ", Milk";
            this.Cost += .10m;
        }

        public override decimal Cost
        {
            get
            {
                return beverage.Cost;
            }
            set
            {
                beverage.Cost = value;
            }
        }
        public override string Description
        {
            get
            {
                return beverage.Description;
            }
            set
            {
                beverage.Description = value;
            }
        }
    }
}