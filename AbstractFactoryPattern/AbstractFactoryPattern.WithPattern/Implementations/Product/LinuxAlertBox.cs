using AbstractFactoryPattern.WithPattern.Abstractions.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Product;

/// <summary>
/// Concrete Product
/// </summary>
public class LinuxAlertBox : AlertBox
{
    public LinuxAlertBox()
    {
        Console.WriteLine("This is an alert box that works on Linux");
        Display();
    }
    
    public override void Display()
    {
        Console.WriteLine("> The Linux alert box is now displayed");
    }
}