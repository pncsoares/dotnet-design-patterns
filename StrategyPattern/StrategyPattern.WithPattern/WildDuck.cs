using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class WildDuck : Duck
{
    public WildDuck(IDisplayStrategy displayStrategy, IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, IEatStrategy eatStrategy) 
        : base(displayStrategy, quackStrategy, flyStrategy, eatStrategy)
    {
        Console.WriteLine("I am a wild duck");
    }
}