using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    public class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShoudReturnerrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
} 