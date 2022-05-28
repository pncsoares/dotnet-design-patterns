using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Display;

public class AnimalDisplayBehavior : IDisplayBehavior
{
    public void Display()
    {
        Console.WriteLine("I am an animal");
    }
}