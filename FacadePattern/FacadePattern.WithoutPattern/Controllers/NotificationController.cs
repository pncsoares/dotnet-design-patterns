using FacadePattern.WithoutPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.WithoutPattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;
    
    public NotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpPost(Name = "SendNotification")]
    public void Post([FromBody] string message)
    {
        _notificationService.Send(message);
    }
}