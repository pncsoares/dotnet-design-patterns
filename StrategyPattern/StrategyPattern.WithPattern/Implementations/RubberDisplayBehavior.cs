using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class RubberDisplayBehavior : IDisplayBehavior
{
    public void Display()
    {
        Console.WriteLine("I am rubber duck");
    }
}