using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Email _email;
        private readonly Document _document;
        private readonly Address _address;
        private readonly Student _student;
        private readonly Subscription _subscription;

        public StudentTests()
        //metodo construtor
        {
            _name = new Name("Bruce", "Wayne");
            _document = new Document("15796479647", EDocumentType.CPF);
            _email = new Email("batman@dc.com");
            _address = new Address("Rua 1", "123", "Bairro Legal", "Gotham", "RJ", "BR", "3570000");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "WAYNE CORP", _document, _address, _email);

            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);
            //adicionando a assinatura pela segunda vez para dar o erro.

            Assert.IsTrue(_student.Invalid);
            //se o customer ja tiver assinatura ativa, retorna um erro.
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_student.Invalid);
            //retorna um erro quando a assinatura não tiver pagamento.
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "WAYNE CORP", _document, _address, _email);
            _subscription.AddPayment(payment);
            //adicionando um pagamento
            _student.AddSubscription(_subscription);
            //adicionando uma assinatura
            Assert.IsTrue(_student.Valid);
            //se o customer nao tiver assinatura ativa, retorna sucesso.
        }
    }
}