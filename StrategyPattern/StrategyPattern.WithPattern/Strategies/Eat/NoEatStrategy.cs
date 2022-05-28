using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Eat;

public class NoEatStrategy : IEatStrategy
{
    public void Eat()
    {
        Console.WriteLine("I don't eat");
    }
}