using FacadePattern.WithPattern.Interfaces;

namespace FacadePattern.WithPattern.Services;

public class InventoryService : IInventoryService
{
    public string[] Get()
    {
        return new[]
        {
            "Book",
            "Pen"
        };
    }
}