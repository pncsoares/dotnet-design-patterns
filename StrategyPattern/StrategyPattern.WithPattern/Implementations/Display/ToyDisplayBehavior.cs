using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Display;

public class ToyDisplayBehavior : IDisplayBehavior
{
    public void Display()
    {
        Console.WriteLine("I am a toy");
    }
}