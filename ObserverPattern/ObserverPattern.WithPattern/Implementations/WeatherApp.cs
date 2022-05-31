using ObserverPattern.WithPattern.Interfaces;

namespace ObserverPattern.WithPattern.Implementations;

/// <summary>
/// Concrete observer
/// </summary>
public class WeatherApp : IObserver
{
    private readonly WeatherStation _observable;
    private readonly IDisplay _displayImplementation;

    public WeatherApp(WeatherStation observable, IDisplay displayImplementation)
    {
        _observable = observable;
        _displayImplementation = displayImplementation;
    }
    
    public void Update(float celsius)
    {
        _displayImplementation.Display("Weather App", celsius);
    }
}