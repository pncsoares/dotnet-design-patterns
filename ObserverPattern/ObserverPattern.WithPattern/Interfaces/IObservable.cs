namespace ObserverPattern.WithPattern.Interfaces;

/// <summary>
/// Can be called ISubject
/// </summary>
public interface IObservable
{
    /// <summary>
    /// Register (add) an observer/subscriber
    /// </summary>
    /// <param name="observer"></param>
    void Register(IObserver observer);
    
    /// <summary>
    /// Unregister (remove) an observer/subscriber
    /// </summary>
    /// <param name="observer"></param>
    void Unregister(IObserver observer);
    
    /// <summary>
    /// Notify (broadcast) all the registered observers/subscribers
    /// </summary>
    void Notify(float celsius);
}