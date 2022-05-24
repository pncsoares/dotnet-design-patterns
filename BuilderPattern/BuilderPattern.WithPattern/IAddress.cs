namespace BuilderPattern.WithPattern;

public interface IAddress
{
    string Street { get; }
    string Zip { get; }

    /// <summary>
    /// A method to print the address information
    /// </summary>
    /// <returns></returns>
    string Print();
}