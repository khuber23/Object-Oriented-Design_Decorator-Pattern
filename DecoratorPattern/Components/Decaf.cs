namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "Decaf";
            this.cost = 1.00m;
        }

        public override decimal Cost { get => this.cost; set => this.cost = value; }

        public override string Description { get => this.description; set => this.description = value; }
    }
}