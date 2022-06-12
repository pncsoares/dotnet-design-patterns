using AbstractFactoryPattern.WithoutPattern.Abstractions;

namespace AbstractFactoryPattern.WithoutPattern.Implementations;

public class MacOsAlertBox : AlertBox
{
    public MacOsAlertBox()
    {
        Console.WriteLine("Creating an alert box that works on MacOs");
        Display();
    }

    public override void Display()
    {
        Console.WriteLine("> The MacOs alert box is now displayed");
    }
}