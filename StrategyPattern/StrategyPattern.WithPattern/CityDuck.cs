using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class CityDuck : Duck
{
    public CityDuck(IDisplayBehavior displayBehavior, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior, IEatBehavior eatBehavior) 
        : base(displayBehavior, quackBehavior, flyBehavior, eatBehavior)
    {
        Console.WriteLine("I am a city duck");
    }
}