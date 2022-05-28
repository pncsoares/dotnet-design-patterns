using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class MountainDuck : Duck
{
    public MountainDuck(IDisplayBehavior displayBehavior, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior, IEatBehavior eatBehavior) 
        : base(displayBehavior, quackBehavior, flyBehavior, eatBehavior)
    {
        Console.WriteLine("I am a mountain duck");
    }
}