using System;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.Commands
{
    //Os commands nada mais são do que a junção de todas as informações que preciso pra criar uma subscription
    public class CreateCreditCardSubscriptionCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }

        //o Type não precisa estar aqui pq vai ser sempre pessoa fisica que vai ter uma assinatura
        public string Email { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        //Data de pagamento
        public DateTime ExpireDate { get; set; }
        //Data de expiração
        public decimal Total { get; set; }
        //Quanto o cliente tem que pagar
        public decimal TotalPaid { get; set; }
        //Quanto foi pago pelo cliente
        public string Payer { get; set; }
        //proprietário do pagamento (pessoa que vai pagar)
        public string PayerDocument { get; set; }
        //documento da pessoa que vai pagar
        public EDocumentType PayerDocumentType { get; set; }
        public string PayerEmail { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}