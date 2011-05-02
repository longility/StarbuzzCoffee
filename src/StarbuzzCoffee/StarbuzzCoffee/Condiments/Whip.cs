
namespace StarbuzzCoffee.Condiments
{
    class Whip : CondimentDecorator
    {
        private readonly decimal cost = 0.89M;

        public Whip(Beverage beverage) : base(beverage) { }

        public override string Description
        {
            get { return base.decoratedBeverage.Description + ", whip"; }
        }

        public override decimal Cost
        {
            get { return base.decoratedBeverage.Cost + cost; }
        }
    }
}
