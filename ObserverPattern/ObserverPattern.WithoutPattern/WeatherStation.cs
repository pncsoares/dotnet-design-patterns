namespace ObserverPattern.WithoutPattern;

public class WeatherStation
{
    /// <summary>
    /// The temperature in degrees Celsius
    /// </summary>
    private float Celsius { get; set; }

    public void SetTemperature(float celsius)
    {
        Celsius = celsius;
    }

    public float GetTemperature()
    {
        return Celsius;
    }
}