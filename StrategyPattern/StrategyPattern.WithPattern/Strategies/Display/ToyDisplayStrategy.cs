using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Display;

public class ToyDisplayStrategy : IDisplayStrategy
{
    public void Display()
    {
        Console.WriteLine("I am a toy");
    }
}