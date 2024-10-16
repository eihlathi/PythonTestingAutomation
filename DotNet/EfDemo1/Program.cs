using EfDemo1.Models;

Console.WriteLine("Starting to access the Northwind database...");

NorthwindContext context = new();

List<Customer> allCustomer = context.Customers.ToList();

Console.WriteLine("Please enter a country from which to display the customers:");
string country = Console.ReadLine() ?? "";

// LINQ query
var matching = from c in context.Customers
               where c.Country == country
               orderby c.CompanyName
               select c;

foreach (var cust in matching)
{
    Console.WriteLine($"Found match: {cust.CompanyName}, {cust.ContactName}");
}
