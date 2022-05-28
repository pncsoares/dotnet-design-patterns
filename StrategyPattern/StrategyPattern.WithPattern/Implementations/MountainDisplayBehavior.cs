using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class MountainDisplayBehavior : IDisplayBehavior
{
    public void Display()
    {
        Console.WriteLine("I am a mountain duck");
    }
}