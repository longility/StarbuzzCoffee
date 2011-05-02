
using System;
namespace StarbuzzCoffee
{
    abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract decimal Cost { get; }
        protected decimal CondimentCost
        {
            get
            {
                Decimal condimentCost = 0;

                if(milk)
                    condimentCost += milkCost;
                if(soy)
                    condimentCost += soyCost;
                if(mocha)
                    condimentCost += mochaCost;
                if(whip)
                    condimentCost += whipCost;

                return condimentCost;
            }
        }

        private bool milk = false;
        private bool soy = false;
        private bool mocha = false;
        private bool whip = false;

        private decimal milkCost = 0.49M;
        private decimal soyCost = 0.25M;
        private decimal mochaCost = 1.00M;
        private decimal whipCost = 0.89M;

        public bool Milk { get { return milk; } set { milk = value; } }
        public bool Soy { get { return soy; } set { soy = value; } }
        public bool Mocha { get { return mocha; } set { mocha = value; } }
        public bool Whip { get { return whip; } set { whip = value; } }
    }
}
