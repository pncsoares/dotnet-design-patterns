using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Eat;

public class NoEatBehavior : IEatBehavior
{
    public void Eat()
    {
        Console.WriteLine("I don't eat");
    }
}