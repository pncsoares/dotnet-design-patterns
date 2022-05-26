using FacadePattern.WithPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.WithPattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PurchaseFacadeController : ControllerBase
{
    private readonly IInventoryService _inventoryService;
    private readonly IPaymentService _paymentService;
    private readonly INotificationService _notificationService;

    public PurchaseFacadeController(
        IInventoryService inventoryService,
        IPaymentService paymentService,
        INotificationService notificationService)
    {
        _inventoryService = inventoryService;
        _paymentService = paymentService;
        _notificationService = notificationService;
    }

    [HttpPost(Name = "Purchase")]
    public IActionResult Post([FromBody] Purchase input)
    {
        var inventory = _inventoryService.Get();

        if (inventory.All(a => a != input.Item))
        {
            return BadRequest();
        }

        _paymentService.Pay(input.Item, input.Amount);
        _notificationService.Send($"Item: {input.Item} purchase with amount: {input.Amount}");

        return Ok();
    }
}