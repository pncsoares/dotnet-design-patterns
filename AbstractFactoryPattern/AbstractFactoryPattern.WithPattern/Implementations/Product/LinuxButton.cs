using AbstractFactoryPattern.WithPattern.Abstractions.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Product;

/// <summary>
/// Concrete Product
/// </summary>
public class LinuxButton : Button
{
    public LinuxButton()
    {
        Console.WriteLine("This is a button that works on Linux");
        Display();
    }
    
    public override void Display()
    {
        Console.WriteLine("> The Linux button is now displayed");
    }
}