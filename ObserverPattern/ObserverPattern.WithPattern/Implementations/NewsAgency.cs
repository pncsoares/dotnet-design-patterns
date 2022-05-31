using ObserverPattern.WithPattern.Interfaces;

namespace ObserverPattern.WithPattern.Implementations;

/// <summary>
/// Concrete observer
/// </summary>
public class NewsAgency : IObserver
{
    private readonly string _name;
    private readonly WeatherStation _observable;
    private readonly IDisplay _displayImplementation;

    public NewsAgency(string name, WeatherStation observable, IDisplay displayImplementation)
    {
        _name = name;
        _observable = observable;
        _displayImplementation = displayImplementation;
    }
    
    public void Update(float celsius)
    {
        _displayImplementation.Display(_name, celsius);
    }
}