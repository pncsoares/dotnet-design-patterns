using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Quack;

public class NoQuackStrategy : IQuackStrategy
{
    public void Quack()
    {
        Console.WriteLine("I don't quack");
    }
}