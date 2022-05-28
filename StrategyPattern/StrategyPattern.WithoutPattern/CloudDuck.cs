namespace StrategyPattern.WithoutPattern;

public class CloudDuck : Duck
{
    protected override void Display()
    {
        Console.WriteLine("I am a Cloud duck");
    }

    protected override void Fly()
    {
        Console.WriteLine("I fly high");
    }

    protected override void Eat()
    {
        Console.WriteLine("I eat birds");
    }
}