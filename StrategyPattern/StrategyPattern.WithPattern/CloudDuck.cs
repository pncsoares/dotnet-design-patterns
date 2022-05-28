using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class CloudDuck : Duck
{
    public CloudDuck(IDisplayStrategy displayStrategy, IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, IEatStrategy eatStrategy) 
        : base(displayStrategy, quackStrategy, flyStrategy, eatStrategy)
    {
        Console.WriteLine("I am a cloud duck");
    }
}