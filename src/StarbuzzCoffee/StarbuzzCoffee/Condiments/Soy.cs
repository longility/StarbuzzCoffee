
namespace StarbuzzCoffee.Condiments
{
    class Soy : CondimentDecorator
    {
        private readonly decimal cost = 0.25M;

        public Soy(Beverage beverage) : base(beverage) { }

        public override string Description
        {
            get { return base.decoratedBeverage.Description + ", soy"; }
        }

        public override decimal Cost
        {
            get { return base.decoratedBeverage.Cost + cost; }
        }
    }
}
