using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Fly;

public class LowFlyStrategy : IFlyStrategy
{
    public void Fly()
    {
        Console.WriteLine("I fly near the ground");
    }
}