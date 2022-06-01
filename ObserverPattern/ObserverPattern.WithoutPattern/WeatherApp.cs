using System.Timers;
using Timer = System.Timers.Timer;

namespace ObserverPattern.WithoutPattern;

public class WeatherApp
{
    private readonly WeatherStation _weatherStation;
    
    /// <summary>
    /// The timer that will be responsible to do the polling mechanism
    /// </summary>
    private readonly Timer _timer;
    
    /// <summary>
    /// The temperature in degrees Celsius
    /// </summary>
    private float Celsius { get; set; }

    public WeatherApp(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;

        _timer = new Timer(1000)
        {
            AutoReset = true
        };

        _timer.Elapsed += TimerElapsed;
    }

    /// <summary>
    /// Event that will be triggered by the timer,
    /// will grab the data from the Weather Station
    /// and display it in the console
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TimerElapsed(object? sender, ElapsedEventArgs e)
    {
        var celsius = _weatherStation.GetTemperature();

        if (celsius != Celsius)
        {
            Celsius = celsius;
                
            Console.WriteLine($"The temperature changed!");
            Console.WriteLine($"New temperature: {Celsius}ºC");
        }
        else
        {
            Console.WriteLine($"The temperature has not changed...");
        }
    }

    public void StartTimer()
    {
        _timer.Start();
    }

    public void StopTimer()
    {
        _timer.Stop();
    }
}