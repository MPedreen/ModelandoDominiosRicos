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
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("15796479647", EDocumentType.CPF);
            var email = new Email("batman@dc.com");
            var address = new Address("Rua 1", "123", "Bairro Legal", "Gotham", "RJ", "BR", "3570000");
            var student = new Student(name, document, email);
            var subscription = new Subscription(null);
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "WAYNE CORP", document, address, email);

            subscription.AddPayment(payment);
            student.AddSubscription(subscription);
            student.AddSubscription(subscription);
            //adicionando a assinatura pela segunda vez para dar o erro.

            Assert.IsTrue(student.Invalid);
            //se o customer ja tiver assinatura ativa, retorna um erro.
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("15796479647", EDocumentType.CPF);
            var email = new Email("batman@dc.com");
            var student = new Student(name, document, email);

            Assert.Fail();
            //retorna um erro quando a assinatura não tiver pagamento.
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            Assert.Fail();
            //se o customer nao tiver assinatura ativa, retorna sucesso.
        }
    }
}