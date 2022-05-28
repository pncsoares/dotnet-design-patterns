using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Eat;

public class MeatEatBehavior : IEatBehavior
{
    public void Eat()
    {
        Console.WriteLine("I eat meat");
    }
}