using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class NoQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
    }
}