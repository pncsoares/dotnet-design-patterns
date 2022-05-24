namespace FacadePattern.WithoutPattern.Interfaces;

public interface IPaymentService
{
    void Pay(string item, double amount);
}