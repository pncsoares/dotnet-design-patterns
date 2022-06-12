using AbstractFactoryPattern.WithPattern.Abstractions.Factory;
using AbstractFactoryPattern.WithPattern.Abstractions.Product;
using AbstractFactoryPattern.WithPattern.Implementations.Product;

namespace AbstractFactoryPattern.WithPattern.Implementations.Factory;

/// <summary>
/// Concrete Factory
/// </summary>
public class LinuxUiControlsFactory : UiControlFactory
{
    public LinuxUiControlsFactory()
    {
        Console.WriteLine("\nLinux Factory starting...");
    }
    
    public override AlertBox GetAlertBox()
    {
        return new LinuxAlertBox();
    }

    public override Button GetButton()
    {
        return new LinuxButton();
    }
}