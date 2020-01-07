using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests 
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura() 
        {
            var subscription = new Subscription(null);
            var student = new Student("Lucas", "Val", "12345678912", "lucas.val@io");
            student.AddSubscription(subscription);

        }
    }
}