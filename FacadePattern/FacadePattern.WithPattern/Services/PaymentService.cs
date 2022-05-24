using FacadePattern.WithPattern.Interfaces;

namespace FacadePattern.WithPattern.Services;

public class PaymentService : IPaymentService
{
    public void Pay(string item, double amount)
    {
        Console.WriteLine($"Paying amount: {amount} for item: {item}");
    }
}