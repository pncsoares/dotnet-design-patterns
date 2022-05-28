using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Quack;

public class QuietQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("quack quack");
    }
}