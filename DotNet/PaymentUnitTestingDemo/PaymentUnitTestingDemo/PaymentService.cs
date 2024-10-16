using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUnitTestingDemo
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount, string paymentMethod)
        {
            if (paymentMethod == "CreditCard")
            {
                // complex logic here
                return true;
            }
            if (paymentMethod == "Bitcoin")
            {
                // another complex code block
                return true;
            }
            return false;
        }
    }
}
