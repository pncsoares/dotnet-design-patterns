using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class WildDisplayBehavior : IDisplayBehavior
{
    public void Display()
    {
        Console.WriteLine("I am a wild duck");
    }
}