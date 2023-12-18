namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend";
            this.cost = 1.10m;
        }

        public override decimal Cost { get => this.cost; set => this.cost = value; }

        public override string Description { get => this.description; set => this.description = value; }
    }
}