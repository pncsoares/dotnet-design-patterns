using AbstractFactoryPattern.WithPattern.Abstractions.Factory;
using AbstractFactoryPattern.WithPattern.Abstractions.Product;
using AbstractFactoryPattern.WithPattern.Implementations.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Factory;

/// <summary>
/// Concrete Factory
/// </summary>
public class WindowsUiControlsFactory : UiControlFactory
{
    public WindowsUiControlsFactory()
    {
        Console.WriteLine("\nWindows Factory starting...");    
    }
    
    public override AlertBox GetAlertBox()
    {
        return new WindowsAlertBox();
    }

    public override Button GetButton()
    {
        return new WindowsButton();
    }
}