using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            //Gerando Guid, removendo os traços do guid, pegando os 10 primeiros caracteres e transformando em maiúsculo.
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;

            //Validações:
            AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(0, Total, "Payment.Total", "O total não pode ser zero")
            .IsGreaterOrEqualsThan(Total, TotalPaid, "Payment.TotalPaid", "O valor pago é menor que o valor de pagamento")
            );
        }

        public string Number { get; private set; }
        //Propriedade para gerar um Guid do pagamento, para identificar esse pagamento
        public DateTime PaidDate { get; private set; }
        //Data de pagamento
        public DateTime ExpireDate { get; private set; }
        //Data de expiração
        public decimal Total { get; private set; }
        //Quanto o cliente tem que pagar
        public decimal TotalPaid { get; private set; }
        //Quanto foi pago pelo cliente
        public string Payer { get; private set; }
        //proprietário do pagamento (pessoa que vai pagar)
        public Document Document { get; private set; }
        //documento da pessoa que vai pagar
        public Address Address { get; private set; }
        //Endereço de cobrança, utilizado para emitir nota.
        //O endereço  de cobrança pode ser diferente do endereço de entrega.
        public Email Email { get; private set; }
    }
}