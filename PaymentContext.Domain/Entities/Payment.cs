using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public string Number { get; set; }
        //Propriedade para gerar um Guid do pagamento, para identificar esse pagamento
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
        public string Document { get; set; }
        //documento da pessoa que vai pagar
        public string Adress { get; set; }
        //Endereço de cobrança, utilizado para emitir nota.
        //O endereço  de cobrança pode ser diferente do endereço de entrega.
        public string Email { get; set; }
    }
    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        //código de barras
        public string BoletoNumber { get; set; }
        //numero do boleto, normalmente gerado no banco de dados
    }
    public class CreditCardPayment : Payment
    {
        //não armazenar ccv do cartão e data de expiração. (Se um dia vazar esses dados do banco da sua empresa, pode ser processada)
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }
    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; set; }
        //codígo de transação que o paypal gera
    }
}