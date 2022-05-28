using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations;

public class CloudDisplayBehavior : IDisplayBehavior
{
    public void Display()
    {
        Console.WriteLine("I am a cloud duck");
    }
}