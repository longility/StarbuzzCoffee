using System;

namespace StarbuzzCoffee
{
    class HouseBlend : Beverage
    {
        public override string Description
        {
            get { return "Espresso"; }
        }

        public override Decimal Cost
        {
            get { return 2.79M; }
        }
    }
}
