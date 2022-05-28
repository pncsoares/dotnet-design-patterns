using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Display;

public class AnimalDisplayStrategy : IDisplayStrategy
{
    public void Display()
    {
        Console.WriteLine("I am an animal");
    }
}