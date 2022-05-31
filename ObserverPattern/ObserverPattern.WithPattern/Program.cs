﻿using ObserverPattern.WithPattern;
using ObserverPattern.WithPattern.Implementations;

var weatherStation = new WeatherStation();
var displayTemperature = new DisplayTemperature();

var channel1 = new NewsAgency("Channel 1", weatherStation, displayTemperature);
weatherStation.Register(channel1);

var channel2 = new NewsAgency("Channel 2", weatherStation, displayTemperature);
weatherStation.Register(channel2);

var weatherApp = new WeatherApp(weatherStation, displayTemperature);
weatherStation.Register(weatherApp);

weatherStation.SetTemperature(22.3f);

weatherStation.Unregister(channel2);

Console.WriteLine(); // just to format the console log
weatherStation.SetTemperature(16);

Console.WriteLine(); // just to format the console log
weatherStation.SetTemperature(39.8f);