namespace StrategyPattern.WithoutPattern;

public class RubberDuck : Duck
{
    protected override void Display()
    {
        Console.WriteLine("I am a Rubber duck");
    }

    protected override void Quack()
    {
        Console.WriteLine("I can't quack");
    }

    protected override void Fly()
    {
        Console.WriteLine("I can't fly");
    }
    
    protected override void Eat()
    {
        Console.WriteLine("I don't eat...");
    }
}