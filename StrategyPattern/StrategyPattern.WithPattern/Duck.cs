using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public abstract class Duck : IDisplayBehavior, IQuackBehavior, IFlyBehavior, IEatBehavior
{
    private readonly IDisplayBehavior _displayBehavior;
    private readonly IQuackBehavior _quackBehavior;
    private readonly IFlyBehavior _flyBehavior;
    private readonly IEatBehavior _eatBehavior;

    protected Duck(IDisplayBehavior displayBehavior, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior, IEatBehavior eatBehavior)
    {
        _displayBehavior = displayBehavior;
        _quackBehavior = quackBehavior;
        _flyBehavior = flyBehavior;
        _eatBehavior = eatBehavior;

        Display();
        Quack();
        Fly();
        Eat();

        // just to add a space between duck sentences in the console
        Console.WriteLine();
    }

    public void Display()
    {
        _displayBehavior.Display();
    }

    public void Quack()
    {
        _quackBehavior.Quack();
    }
    
    public void Fly()
    {
        _flyBehavior.Fly();
    }
    
    public void Eat()
    {
        _eatBehavior.Eat();
    }
}