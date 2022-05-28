using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class EatBirdBehavior : IEatBehavior
{
    public void Eat()
    {
        Console.WriteLine("I eat birds");
    }
}