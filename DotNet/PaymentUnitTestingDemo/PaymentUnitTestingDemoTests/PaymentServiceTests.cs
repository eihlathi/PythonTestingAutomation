using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentUnitTestingDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUnitTestingDemo.Tests
{
    [TestClass()]
    public class PaymentServiceTests
    {
        [TestMethod()]
        public void ProcessPaymentTest()
        {
            string paymentMethod = "CreditCard";
            decimal amount = 100;
            PaymentService paymentService = new PaymentService();
            bool result = paymentService.ProcessPayment(amount, paymentMethod);
            Assert.IsTrue(result);

            paymentMethod = "Bitcoin";
            result = paymentService.ProcessPayment(amount, paymentMethod);
            Assert.IsTrue(result);

            paymentMethod = "PayPal";
            result = paymentService.ProcessPayment(amount, paymentMethod);
            Assert.IsFalse(result);
        }
    }
}