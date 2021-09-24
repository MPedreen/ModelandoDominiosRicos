namespace PaymentContext.Domain.Services
{
    public interface IEmailService
    {
        // enviar email
        void Send(string to, string email, string subject, string body);
    }
}