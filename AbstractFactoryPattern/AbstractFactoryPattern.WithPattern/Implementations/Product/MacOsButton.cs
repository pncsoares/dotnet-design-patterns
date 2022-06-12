using AbstractFactoryPattern.WithPattern.Abstractions.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Product;

/// <summary>
/// Concrete Product
/// </summary>
public class MacOsButton : Button
{
    public MacOsButton()
    {
        Console.WriteLine("This is a button that works on MacOs");
        Display();
    }
    
    public override void Display()
    {
        Console.WriteLine("> The MacOs button is now displayed");
    }
}