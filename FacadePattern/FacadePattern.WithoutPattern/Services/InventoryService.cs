using FacadePattern.WithoutPattern.Interfaces;

namespace FacadePattern.WithoutPattern.Services;

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