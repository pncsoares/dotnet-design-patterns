using ObserverPattern.WithPattern.Interfaces;

namespace ObserverPattern.WithPattern.Implementations;

/// <summary>
/// Concrete observable
/// </summary>
public class WeatherStation : IObservable
{
    /// <summary>
    /// The list of observers/subscribers registered
    /// </summary>
    private readonly IList<IObserver> _observers;

    /// <summary>
    /// The temperature in degrees Celsius
    /// </summary>
    private float _celsius;

    public WeatherStation()
    {
        _observers = new List<IObserver>();
    }
    
    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unregister(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(float celsius)
    {
        foreach (var observer in _observers)
        {
            observer.Update(celsius);
        }
    }

    public void SetTemperature(float celsius)
    {
        _celsius = celsius;
        Notify(celsius);
    }
}