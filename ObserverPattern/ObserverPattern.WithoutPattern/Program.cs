using ObserverPattern.WithoutPattern;

var weatherStation = new WeatherStation();

weatherStation.SetTemperature(12.2f);

var weatherApp = new WeatherApp(weatherStation);
weatherApp.StartTimer();

// wait a bit to simulate real life scenario
Thread.Sleep(3000);

weatherStation.SetTemperature(12.3f);

// wait a bit to simulate real life scenario
Thread.Sleep(4000);

weatherStation.SetTemperature(12.4f);

// wait a bit to simulate real life scenario
Thread.Sleep(7000);

weatherStation.SetTemperature(12.6f);

// wait a bit to simulate real life scenario
Thread.Sleep(2000);

weatherApp.StopTimer();