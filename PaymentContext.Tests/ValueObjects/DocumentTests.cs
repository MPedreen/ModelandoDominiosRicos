using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor
        //red = escrever os testes e fazer eles falharem, green = fazer os testes passarem e isso virará uma bagunça, refactor = refatorar o código. 

        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
            //o teste vai passar se o documento for inválido
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("41813708000149", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
            //o teste vai passar se o documento for válido
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsValid()
        {
            var doc = new Document("27127120056", EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }

        /*
        Se eu quiser testar vários cpf's de uma vez só, faço assim:

        [TestMethod]
        [DataTestMethod]
        [DataRow("27127120056")]
        [DataRow("22325160796")]
        [DataRow("12323668498")]

        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
        */
    }
}