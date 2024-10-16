using System.Text.Json;

public class ContactHandler
{
    const string JsonFilename = "Contacts.json";

    private List<Contact> allContacts = [];

    public Contact AskContactDetailsFromUser()
    {
        Console.WriteLine("Please enter the contact name:");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine("Please enter the contact email address:");
        string email = Console.ReadLine() ?? "";

        Console.WriteLine("Please enter the contact comments:");
        string comments = Console.ReadLine() ?? "";

        Contact contact = new()
        {
            Name = name,
            Email = email,
            Comments = comments
        };

        return contact;
    }

    public void AddContact(Contact contact)
    {
        ReadAllContacts();
        allContacts.Add(contact);
        WriteAllContacts();
    }

    public void ListAllContacts()
    {
        ReadAllContacts();
        foreach (Contact c in allContacts)
        {
            Console.WriteLine(c);
            // Console.WriteLine($"Name: {c.Name}");
            // Console.WriteLine($"\tEmail: {c.Email}");
            // Console.WriteLine($"\tComments: {c.Comments}");
        }
    }

    public void SearchContactByName()
    {
        Console.WriteLine("Please enter the contact name to search for:");
        string name = (Console.ReadLine() ?? "").ToLower();

        ReadAllContacts();
        int matchCount = 0;
        foreach (Contact c in allContacts)
        {
            // if (c.Name == name)
            if (c.Name.ToLower().Contains(name))
            {
                Console.WriteLine(c);
                matchCount++;
            }
        }

        Console.WriteLine($"Found total {matchCount} match(es).");
    }

    public void DeleteContactByName()
    {
        Console.WriteLine("Enter the name of the contact you want to delete:");
        string nameToDelete = Console.ReadLine() ?? "";

        // Find contact with matching name
        Contact? contactToDelete = allContacts.FirstOrDefault(c => c.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

        if (contactToDelete != null)
        {
            allContacts.Remove(contactToDelete);
            WriteAllContacts();
            Console.WriteLine($"Contact '{contactToDelete.Name}' has been deleted.");
        }
        else
        {
            Console.WriteLine("No contact found with the specified name.");
        }
    }

    private void ReadAllContacts()
    {
        if (File.Exists(JsonFilename))
        {
            string json = File.ReadAllText(JsonFilename);
            allContacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? [];
        }
        else
        {
            allContacts = [];
        }
    }

    private void WriteAllContacts()
    {
        string json = JsonSerializer.Serialize(allContacts);
        File.WriteAllText(JsonFilename, json);
    }
}