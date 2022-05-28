namespace StrategyPattern.WithoutPattern;

public class WildDuck : Duck
{
    protected override void Display()
    {
        Console.WriteLine("I am a Wild duck");
    }
}