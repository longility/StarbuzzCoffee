
using System;
namespace StarbuzzCoffee
{
    abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract Decimal Cost { get; }
    }
}
