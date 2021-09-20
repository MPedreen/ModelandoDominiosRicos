using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        //endereço de entrega do produto.
        public List<Subscription> Subscriptions { get; set; }
        //o aluno pode ter várias assinaturas, porém, só uma ativa.
    }
}