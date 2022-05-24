namespace SingletonPattern.WithoutPattern;

public class Printer
{
    private static int _counter = 0;
    
    public Printer()
    {
        _counter++;
        Console.WriteLine($"Counter value {_counter}");
    }
    
    /// <summary>
    /// Print a message to the console
    /// </summary>
    /// <param name="message"></param>
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}