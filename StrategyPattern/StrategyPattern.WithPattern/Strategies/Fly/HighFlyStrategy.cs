using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Fly;

public class CloudFlyStrategy : IFlyStrategy
{
    public void Fly()
    {
        Console.WriteLine("I fly high");
    }
}