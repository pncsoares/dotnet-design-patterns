using FacadePattern.WithoutPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.WithoutPattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InventoryController : ControllerBase
{
    private readonly IInventoryService _inventoryService;
    
    public InventoryController(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }
    
    [HttpGet(Name = "GetInventory")]
    public IEnumerable<string> Get()
    {
        return _inventoryService.Get();
    }
}