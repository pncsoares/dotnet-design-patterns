using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class CityDisplayBehavior : IDisplayBehavior
{
    public void Display()
    {
        Console.WriteLine("I am a city duck");
    }
}