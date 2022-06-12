using AbstractFactoryPattern.WithPattern.Abstractions.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Product;

/// <summary>
/// Concrete Product
/// </summary>
public class WindowsButton : Button
{
    public WindowsButton()
    {
        Console.WriteLine("This is a button that works on Windows");
        Display();
    }
    
    public override void Display()
    {
        Console.WriteLine("> The Windows button is now displayed");
    }
}