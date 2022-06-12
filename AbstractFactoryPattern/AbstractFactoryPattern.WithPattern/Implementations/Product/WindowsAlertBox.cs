using AbstractFactoryPattern.WithPattern.Abstractions.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Product;

/// <summary>
/// Concrete Product
/// </summary>
public class WindowsAlertBox : AlertBox
{
    public WindowsAlertBox()
    {
        Console.WriteLine("This is an alert box that works on Windows");
        Display();
    }
    
    public override void Display()
    {
        Console.WriteLine("> The Windows alert box is now displayed");
    }
}