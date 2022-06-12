using AbstractFactoryPattern.WithPattern.Abstractions.Product;

namespace AbstractFactoryPattern.WithPattern.Abstractions.Factory;

/// <summary>
/// Factory
/// </summary>
public abstract class UiControlFactory
{
    public abstract AlertBox GetAlertBox();
    
    public abstract Button GetButton();
}