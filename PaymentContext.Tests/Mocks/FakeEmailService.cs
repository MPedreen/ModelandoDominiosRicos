using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services;

namespace PaymentContext.Tests.Mocks
{
    //Este arquivo é chamado de repositório falso (mocks ou fakes), é usado para ser um banco de dados falso, aonde vou guardar informações e testar, sem precisar da utilização de um banco de dados.
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {
            throw new System.NotImplementedException();
        }
    }
}