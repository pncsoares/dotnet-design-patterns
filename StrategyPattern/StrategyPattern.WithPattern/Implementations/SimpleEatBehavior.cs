using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class SimpleEatBehavior : IEatBehavior
{
    public void Eat()
    {
        Console.WriteLine("I eat almost everything");
    }
}