using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public class RubberDuck : Duck
{
    public RubberDuck(IDisplayBehavior displayBehavior, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior, IEatBehavior eatBehavior) 
        : base(displayBehavior, quackBehavior, flyBehavior, eatBehavior)
    {
    }
}