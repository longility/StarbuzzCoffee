
namespace StarbuzzCoffee
{
    class HouseBlend : Beverage
    {
        public override string Description
        {
            get { return "House blend coffee"; }
        }

        public override decimal Cost
        {
            get { return 2.99M; }
        }
    }
}
