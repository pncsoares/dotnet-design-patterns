namespace StrategyPattern.WithoutPattern;

public abstract class Duck
{
    protected Duck()
    {
        Display();
        Quack();
        Fly();
        Eat();

        // just to add a space between duck sentences in the console
        Console.WriteLine();
    }

    protected virtual void Display()
    {
        Console.WriteLine("I am a duck");
    }

    protected virtual void Quack()
    {
        Console.WriteLine("quack quack");   
    }

    protected virtual void Fly()
    {
        Console.WriteLine("I am flying...");
    }

    protected virtual void Eat()
    {
        Console.WriteLine("I eat almost everything");
    }
}