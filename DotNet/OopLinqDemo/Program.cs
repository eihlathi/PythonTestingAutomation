Console.WriteLine("Starting the OOP/LINQ demo...");

// data initialization
List<Person> persons =
[
    new Person("John Doe", "123 Maple Street, Springfield", "USA"),
    new Person("Jane Smith", "456 Oak Avenue, Metropolis", "USA"),
    new Person("Alice Johnson", "789 Pine Lane, Gotham", "Canada"),
    new Person("Bob Brown", "101 Birch Road, Smallville", "UK"),
    new Person("Charlie Davis", "202 Cedar Court, Star City", "Australia")
];

// ask the user for the country to search for
Console.WriteLine("Please enter a country name to search for:");
string country = Console.ReadLine() ?? "";

// LINQ query
var matching = from p in persons
               where p.Country == country
               orderby p.Name
               select p;

// display results on the screen
foreach (Person p in matching)
{
    Console.WriteLine($"Matching: {p.Name} from " +
        $"{p.Address}, {p.Country}.");
}

Console.WriteLine("-------------");
Console.WriteLine("Application exiting.");
