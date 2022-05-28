using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Fly;

public class NoFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}