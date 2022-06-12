using AbstractFactoryPattern.WithoutPattern.Implementations;

Console.WriteLine("\nMacOs Factory starting...");
var macOsAlertBox = new MacOsAlertBox();
var macOsButton = new MacOsButton();

Console.WriteLine("\nLinux Factory starting...");
var linuxAlertBox = new LinuxAlertBox();
var linuxButton = new LinuxButton();

Console.WriteLine("\nWindows Factory starting...");
var windowsAlertBox = new WindowsAlertBox();
var windowsButton = new WindowsButton();