using FactoryMethodPattern.WithoutPattern.Interfaces;

namespace FactoryMethodPattern.WithoutPattern;

public class Duck : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Quack Quack");
    }
}