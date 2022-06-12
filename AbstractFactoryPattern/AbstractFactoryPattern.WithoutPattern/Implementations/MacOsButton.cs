using AbstractFactoryPattern.WithoutPattern.Abstractions;

namespace AbstractFactoryPattern.WithoutPattern.Implementations;

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