using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Fly;

public class CloudFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I fly high");
    }
}