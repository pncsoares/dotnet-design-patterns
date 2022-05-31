using ObserverPattern.WithPattern.Interfaces;

namespace ObserverPattern.WithPattern.Implementations;

public class DisplayTemperature : IDisplay
{
    public void Display(string name, float celsius)
    {
        Console.WriteLine($"[{name}] The temperature is {celsius}ºC");
    }
}