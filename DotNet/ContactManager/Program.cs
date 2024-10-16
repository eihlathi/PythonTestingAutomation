Console.WriteLine("Welcome to the ContactManager application!");
Console.WriteLine("Version: 0.9");

ContactHandler handler = new();

while (true)
{
    int choice = DisplayMenuAndAskTheChoice();

    switch (choice)
    {
        case 1:
            Contact contact = handler.AskContactDetailsFromUser();
            handler.AddContact(contact);
            Console.WriteLine("New contact person added and stored to disk.");
            break;
        case 2:
            handler.ListAllContacts();
            break;
        case 3:
            handler.SearchContactByName();
            break;
        case 4:
            handler.DeleteContactByName();
            break;
        default:
            Console.WriteLine("ContactManager exiting.");
            return;
    }
}

int DisplayMenuAndAskTheChoice() 
{
    Console.WriteLine("Please select your command from the below:");
    Console.WriteLine("\t1. Adding and saving a new contact");
    Console.WriteLine("\t2. Listing all contacts.");
    Console.WriteLine("\t3. Searching for contacts by name");
    Console.WriteLine("\t4. Deleting a contact");
    Console.WriteLine("\t5. Exit the application");

    Console.Write("Please select (1-5): ");
    int choice = int.Parse(Console.ReadLine() ?? "5");

    return choice;
}