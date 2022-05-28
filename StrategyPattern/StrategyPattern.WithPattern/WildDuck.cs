using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class WildDuck : Duck
{
    public WildDuck(IDisplayBehavior displayBehavior, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior, IEatBehavior eatBehavior) 
        : base(displayBehavior, quackBehavior, flyBehavior, eatBehavior)
    {
    }
}