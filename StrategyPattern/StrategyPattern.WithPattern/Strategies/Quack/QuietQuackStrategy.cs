using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Quack;

public class QuietQuackStrategy : IQuackStrategy
{
    public void Quack()
    {
        Console.WriteLine("quack quack");
    }
}