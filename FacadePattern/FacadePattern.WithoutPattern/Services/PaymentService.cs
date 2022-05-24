using FacadePattern.WithoutPattern.Interfaces;

namespace FacadePattern.WithoutPattern.Services;

public class PaymentService : IPaymentService
{
    public void Pay(string item, double amount)
    {
        Console.WriteLine($"Paying amount: {amount} for item: {item}");
    }
}