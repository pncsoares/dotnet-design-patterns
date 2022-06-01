using ObserverPattern.WithPattern.Interfaces;

namespace ObserverPattern.WithPattern.Implementations;

/// <summary>
/// Concrete observer
/// </summary>
public class WeatherApp : IObserver
{
    private readonly IDisplay _displayImplementation;

    public WeatherApp(IDisplay displayImplementation)
    {
        _displayImplementation = displayImplementation;
    }
    
    public void Update(float celsius)
    {
        _displayImplementation.Display("Weather App", celsius);
    }
}