using FacadePattern.WithoutPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.WithoutPattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    
    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpPost(Name = "PayForItem")]
    public void Post([FromBody] Purchase input)
    {
        _paymentService.Pay(input.Item, input.Amount);
    }
}