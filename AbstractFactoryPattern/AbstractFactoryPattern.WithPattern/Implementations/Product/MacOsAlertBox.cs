using AbstractFactoryPattern.WithPattern.Abstractions.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Product;

/// <summary>
/// Concrete Product
/// </summary>
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