using FacadePattern.WithoutPattern.Interfaces;

namespace FacadePattern.WithoutPattern.Services;

public class NotificationService : INotificationService
{
    /// <summary>
    /// Method that will write a message in the console
    /// </summary>
    /// <param name="message"></param>
    public void Send(string message)
    {
        Console.WriteLine($"Sending notification message: {message}");
    }
}