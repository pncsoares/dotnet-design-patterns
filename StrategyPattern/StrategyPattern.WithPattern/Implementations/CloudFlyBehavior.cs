using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class CloudFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I fly high");
    }
}