using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class CloudDuck : Duck
{
    public CloudDuck(IDisplayBehavior displayBehavior, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior, IEatBehavior eatBehavior) 
        : base(displayBehavior, quackBehavior, flyBehavior, eatBehavior)
    {
    }
}