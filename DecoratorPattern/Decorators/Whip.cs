using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        public Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description += ", Whip";
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