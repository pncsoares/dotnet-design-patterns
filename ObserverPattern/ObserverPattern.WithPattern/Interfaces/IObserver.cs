namespace ObserverPattern.WithPattern.Interfaces;

/// <summary>
/// Can be called ISubscriber
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Update the data using push mechanism
    /// </summary>
    void Update(float celsius);
}