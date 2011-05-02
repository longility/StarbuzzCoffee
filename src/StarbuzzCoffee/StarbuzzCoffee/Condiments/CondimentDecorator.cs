
namespace StarbuzzCoffee.Condiments
{
    abstract class CondimentDecorator : Beverage
    {
        protected readonly Beverage decoratedBeverage;

        protected CondimentDecorator(Beverage beverage)
        {
            this.decoratedBeverage = beverage;
        }
    }
}
