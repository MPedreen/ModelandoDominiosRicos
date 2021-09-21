using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string adress, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            //Gerando Guid, removendo os traços do guid, pegando os 10 primeiros caracteres e transformar em maiúsculo.
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Adress = adress;
            Email = email;
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
        public string Document { get; private set; }
        //documento da pessoa que vai pagar
        public string Adress { get; private set; }
        //Endereço de cobrança, utilizado para emitir nota.
        //O endereço  de cobrança pode ser diferente do endereço de entrega.
        public string Email { get; private set; }
    }
}