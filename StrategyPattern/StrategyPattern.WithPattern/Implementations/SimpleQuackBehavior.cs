using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class SimpleQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("quack quack");
    }
}