using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Eat;

public class MeatEatStrategy : IEatStrategy
{
    public void Eat()
    {
        Console.WriteLine("I eat meat");
    }
}