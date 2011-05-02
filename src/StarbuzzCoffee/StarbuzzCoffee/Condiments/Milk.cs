
namespace StarbuzzCoffee.Condiments
{
    class Milk : CondimentDecorator
    {
        private readonly decimal cost = 0.49M;

        public Milk(Beverage beverage) : base(beverage) { }

        public override string Description
        {
            get { return base.decoratedBeverage.Description + ", milk"; }
        }

        public override decimal Cost
        {
            get { return base.decoratedBeverage.Cost + cost; }
        }
    }
}
