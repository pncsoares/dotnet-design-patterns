using AbstractFactoryPattern.WithPattern.Abstractions.Factory;
using AbstractFactoryPattern.WithPattern.Abstractions.Product;
using AbstractFactoryPattern.WithPattern.Implementations.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Factory;

/// <summary>
/// Concrete Factory
/// </summary>
public class MacOsUiControlsFactory : UiControlFactory
{
    public MacOsUiControlsFactory()
    {
        Console.WriteLine("\nMacOs Factory starting...");    
    }
    
    public override AlertBox GetAlertBox()
    {
        return new MacOsAlertBox();
    }

    public override Button GetButton()
    {
        return new MacOsButton();
    }
}