using System;

namespace StarbuzzCoffee
{
    class HouseBlend : Beverage
    {
        public override string Description
        {
            get { return "House blend coffee"; }
        }

        public override Decimal Cost
        {
            get { return 2.99M; }
        }
    }
}
