
namespace StarbuzzCoffee.Condiments
{
    class Mocha : CondimentDecorator
    {
        private readonly decimal cost = 1.00M;

        public Mocha(Beverage beverage) : base(beverage) { }

        public override string Description
        {
            get { return base.decoratedBeverage.Description + ", mocha"; }
        }

        public override decimal Cost
        {
            get { return base.decoratedBeverage.Cost + cost; }
        }
    }
}
