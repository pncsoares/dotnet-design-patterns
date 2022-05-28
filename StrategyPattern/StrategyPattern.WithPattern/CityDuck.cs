using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class CityDuck : Duck
{
    public CityDuck(IDisplayStrategy displayStrategy, IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, IEatStrategy eatStrategy) 
        : base(displayStrategy, quackStrategy, flyStrategy, eatStrategy)
    {
        Console.WriteLine("I am a city duck");
    }
}