using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    //Este arquivo é chamado de repositório falso (mocks ou fakes), é usado para ser um banco de dados falso, aonde vou guardar informações e testar, sem precisar da utilização de um banco de dados.
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {

        }

        public bool DocumentExists(string document)
        {
            if (document == "99999999999")
                return true;

            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "pedro@gmail.com")
                return true;

            return false;
        }
    }
}