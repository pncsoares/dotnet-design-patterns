using System.Timers;
using Timer = System.Timers.Timer;

namespace ObserverPattern.WithoutPattern;

public class NewsAgency
{
    private readonly WeatherStation _weatherStation;
    
    /// <summary>
    /// The timer that will be responsible to do the polling mechanism
    /// </summary>
    private readonly Timer _timer;

    private const string Name = "News Agency";
    
    /// <summary>
    /// The temperature in degrees Celsius
    /// </summary>
    private float Celsius { get; set; }

    public NewsAgency(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;

        _timer = new Timer(500)
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
                
            Console.WriteLine($"[{Name}] The temperature changed!");
            Console.WriteLine($"[{Name}] New temperature: {Celsius}ºC");
        }
        else
        {
            Console.WriteLine($"[{Name}] The temperature has not changed...");
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