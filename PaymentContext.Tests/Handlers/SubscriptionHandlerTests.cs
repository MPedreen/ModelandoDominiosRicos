using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor
        //red = escrever os testes e fazer eles falharem, green = fazer os testes passarem e isso virará uma bagunça, refactor = refatorar o código. 

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentsExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "pedro2@gmail.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "1234567892";
            command.PaymentNumber = "123456789";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "WAYNE CORP";
            command.PayerDocument = "142353464423";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "batman@dc.com";
            command.Street = "rua alcantara";
            command.Number = "234";
            command.Neighborhood = "asdasd";
            command.City = "RJ";
            command.State = "RJ";
            command.Country = "RJ";
            command.ZipCode = "12341412";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}