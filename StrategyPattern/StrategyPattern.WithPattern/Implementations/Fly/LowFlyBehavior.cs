using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Fly;

public class LowFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I fly near the ground");
    }
}