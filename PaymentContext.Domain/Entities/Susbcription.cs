using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity
    {
        private IList<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; set; }
        //Data do início
        public DateTime LastUpdateDate { get; set; }
        //Data da última atualização
        public DateTime? ExpireDate { get; set; }
        //Data de expiração
        public bool Active { get; set; }
        //O aluno só pode ter uma assinatura ativa
        public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray(); } }
        //Lista de pagamentos

        public void AddPayment(Payment payment)
        {
            AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.Payments", "A data do pagemento deve ser futura")
            );

            //if(Valid) // só adiciona se for válido
            _payments.Add(payment);
        }
        public void Activate()
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }
        public void Inactivate()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}