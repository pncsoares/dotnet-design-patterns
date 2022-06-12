using AbstractFactoryPattern.WithoutPattern.Abstractions;

namespace AbstractFactoryPattern.WithoutPattern.Implementations;

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