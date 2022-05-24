namespace FacadePattern.WithPattern.Interfaces;

public interface IPaymentService
{
    void Pay(string item, double amount);
}