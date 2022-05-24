namespace SingletonPattern.WithPattern;

public sealed class Printer
{
    private static int _counter = 0;
    private static Printer? _instance;
    
    public static Printer GetInstance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Printer();
            }
            
            return _instance;
        }
        
        // this code can be converted to the code above using new C# features
        // but I leave it as is because you can understand better how to implement singleton pattern
        // public static Printer GetInstance => _instance ??= new Printer();
    }
    
    private Printer()
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