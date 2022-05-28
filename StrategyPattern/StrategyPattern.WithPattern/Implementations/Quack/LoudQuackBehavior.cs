using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Quack;

public class LoudQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quaaaaaack");
    }
}