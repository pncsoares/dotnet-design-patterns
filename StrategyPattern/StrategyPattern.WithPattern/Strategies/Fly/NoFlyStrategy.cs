using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Fly;

public class NoFlyStrategy : IFlyStrategy
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}