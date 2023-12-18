using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description += ", Mocha";
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