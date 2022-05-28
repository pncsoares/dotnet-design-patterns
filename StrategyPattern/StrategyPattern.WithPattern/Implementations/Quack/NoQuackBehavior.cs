using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Quack;

public class NoQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("I don't quack");
    }
}