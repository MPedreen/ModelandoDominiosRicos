using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public DateTime CreateDate { get; set; }
        //Data do início
        public DateTime LastUpdateDate { get; set; }
        //Data da última atualização
        public DateTime? ExpireDate { get; set; }
        //Data de expiração
        public bool Active { get; set; }
        //O aluno só pode ter uma assinatura ativa
        public List<Payment> Payments { get; set; }
        //Lista de pagamentos
    }
}