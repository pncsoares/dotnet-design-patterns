namespace AbstractFactoryPattern.WithPattern.Abstractions.Product;

/// <summary>
/// Product
/// </summary>
public abstract class AlertBox
{
    /// <summary>
    /// The method to display the AlertBox in the UI
    /// </summary>
    public abstract void Display();
}