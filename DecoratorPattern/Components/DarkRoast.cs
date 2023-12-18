namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast";
            this.cost = 1.20m;
        }

        public override decimal Cost { get => this.cost; set => this.cost = value; }

        public override string Description { get => this.description; set => this.description = value; }
    }
}