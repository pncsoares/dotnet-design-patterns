namespace BuilderPattern.WithPattern;

public interface IUser
{
    string Name { get; }
    int Age { get; }
    Address Address { get; }

    /// <summary>
    /// A method to print the user information
    /// </summary>
    /// <returns></returns>
    string Print();
}