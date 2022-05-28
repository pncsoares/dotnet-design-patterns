using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class RubberDuck : Duck
{
    public RubberDuck(IDisplayStrategy displayStrategy, IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, IEatStrategy eatStrategy) 
        : base(displayStrategy, quackStrategy, flyStrategy, eatStrategy)
    {
        Console.WriteLine("I am a rubber duck");
    }
}