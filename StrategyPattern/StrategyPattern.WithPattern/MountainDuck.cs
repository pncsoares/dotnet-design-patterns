using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class MountainDuck : Duck
{
    public MountainDuck(IDisplayStrategy displayStrategy, IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, IEatStrategy eatStrategy) 
        : base(displayStrategy, quackStrategy, flyStrategy, eatStrategy)
    {
        Console.WriteLine("I am a mountain duck");
    }
}