namespace StrategyPattern.WithoutPattern;

public class CityDuck : Duck
{
    protected override void Display()
    {
        Console.WriteLine("I am a City duck");
    }
}