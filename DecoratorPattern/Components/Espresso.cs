namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "Espresso";
            this.cost = 1.50m;
        }

        public override decimal Cost { get => this.cost; set => this.cost = value; }

        public override string Description { get => this.description; set => this.description = value; }
    }
}