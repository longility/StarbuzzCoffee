
namespace StarbuzzCoffee
{
    class DarkRoast : Beverage
    {
        public override string Description
        {
            get { return "Dark roast coffee"; }
        }

        public override decimal Cost
        {
            get { return 3.99M; }
        }
    }
}
