// See https://aka.ms/new-console-template for more information
using InterfaceDemo;

Console.WriteLine("Hello, World!");

CreditCardPayment creditCardPayment = new();
ProcessPayment(50.0m, creditCardPayment);

BitcoinPayment bitcoinPayment = new();
ProcessPayment(25.0m, bitcoinPayment);

void ProcessPayment(decimal amount, IPaymentProcessor payment)
{
    Console.WriteLine($"Starting to process payment for {amount:C}.");
    payment.ProcessPayment(amount);
}
