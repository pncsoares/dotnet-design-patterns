using AbstractFactoryPattern.WithoutPattern.Abstractions;

namespace AbstractFactoryPattern.WithoutPattern.Implementations;

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