using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Quack;

public class LoudQuackStrategy : IQuackStrategy
{
    public void Quack()
    {
        Console.WriteLine("Quaaaaaack");
    }
}