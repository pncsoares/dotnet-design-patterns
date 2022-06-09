using FactoryMethodPattern.WithoutPattern.Interfaces;

namespace FactoryMethodPattern.WithoutPattern;

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Miau Miau");
    }
}