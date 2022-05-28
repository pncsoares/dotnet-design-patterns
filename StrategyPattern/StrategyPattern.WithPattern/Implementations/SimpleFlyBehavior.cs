using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class SimpleFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I am flying...");
    }
}