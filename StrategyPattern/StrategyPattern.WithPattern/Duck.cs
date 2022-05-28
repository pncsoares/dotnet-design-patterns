using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern;

public abstract class Duck : IDisplayStrategy, IQuackStrategy, IFlyStrategy, IEatStrategy
{
    private readonly IDisplayStrategy _displayStrategy;
    private readonly IQuackStrategy _quackStrategy;
    private readonly IFlyStrategy _flyStrategy;
    private readonly IEatStrategy _eatStrategy;

    protected Duck(IDisplayStrategy displayStrategy, IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, IEatStrategy eatStrategy)
    {
        _displayStrategy = displayStrategy;
        _quackStrategy = quackStrategy;
        _flyStrategy = flyStrategy;
        _eatStrategy = eatStrategy;

        ExecuteOperations();
    }

    private void ExecuteOperations()
    {
        // just to add a space between duck sentences in the console
        Console.WriteLine();
        
        Display();
        Quack();
        Fly();
        Eat();
    }

    public void Display()
    {
        _displayStrategy.Display();
    }

    public void Quack()
    {
        _quackStrategy.Quack();
    }
    
    public void Fly()
    {
        _flyStrategy.Fly();
    }
    
    public void Eat()
    {
        _eatStrategy.Eat();
    }
}