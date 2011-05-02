
namespace StarbuzzCoffee
{
    class Decaf : Beverage
    {
        public override string Description
        {
            get { return "Decaf coffee"; }
        }

        public override decimal Cost
        {
            get { return 2.49M + CondimentCost; }
        }
    }
}
