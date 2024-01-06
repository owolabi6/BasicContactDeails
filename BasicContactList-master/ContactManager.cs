using System.Collections.Generic;
using ConsoleTables;
using Humanizer;

namespace BasicContactList
{
    internal sealed class ContactManager : IContactManager
    {
        public static List<Contact> Contacts = new();
        private IEnumerable<object> lines;


#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        public void AddContact(string name, string phoneNumber, string? email, ContactType contactType)
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        {
            try
            {
                int id = Contacts.Count > 0 ? Contacts.Count + 1 : 1;


            var isContactExist = IsContactExist(phoneNumber);

            if (isContactExist)
            {
                throw new contactException("Contact already exist!");
                // Console.WriteLine();
                // return;
            }

            var contact = new Contact
            {
                Id = id,
                Name = name,
                PhoneNumber = phoneNumber,
                Email = email,
                ContactType = contactType,
                CreatedAt = DateTime.Now
            };

            Contacts.Add(contact);
            using (StreamWriter writer = File.AppendText("Contact.txt"))
            {
                writer.WriteLine($"Name:  {name}\t" + $"Phone Number: {phoneNumber}\t" + $"Email: {email}\t"+ $"Contact Type: {contactType}"+ $"it was updated at:  {DateTime.Now}\t" );
            }
            Console.WriteLine("Contact added successfully.");
            }
            catch (contactException ex)
            {
                 Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                 Console.WriteLine("Error while adding "+ ex.Message);
            }
        }

        
         public Contact FindContact(string phoneNumber)
        {
            return Contacts.Find(c => c.PhoneNumber == phoneNumber);
        }

        public void GetContact(string phoneNumber)
        {
            var contact = FindContact(phoneNumber);
            
            if (contact is null)
            {
                Console.WriteLine($"Contact with {phoneNumber} not found");
            }
            else
            {
                Print(contact);
            }
        }

 public void DeleteContact(string phoneNumber)
{
    var contact = FindContact(phoneNumber);

    if (contact is null)
    {
        Console.WriteLine("Unable to delete contact as it does not exist!");
        return;
    }

    Contacts.Remove(contact); // Remove contact from the in-memory list

    string filePath = "contact.txt";

    try
    {
        // Read the content of the file using StreamReader
        var lines = new List<string>();
        
        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read all lines into a list
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                // Modify the content as needed
                if (!line.Contains(phoneNumber))
                {
                    lines.Add(line);
                }
            }
        }

        // Write the modified lines back to the file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var modifiedLine in lines)
            {
                writer.WriteLine(modifiedLine);
            }
        }

        Console.WriteLine("Contact deleted successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error while performing file operation: {ex.Message}");
        throw new contactException($"Error while performing file operation: {ex.Message}");
    }
}


        public void GetAllContacts()

        {
            try
            {
                string savedContact = "contact.txt";
                using (StreamReader existngContacts = new StreamReader("contact.txt"))
                {
                    while (!existngContacts.EndOfStream)
                    {
                        string? show = existngContacts.ReadLine();
                        Console.WriteLine(show);
                    }
                }
            }
            catch (contactException)
            {
                 Console.WriteLine("ITA LA WA!");
            }
            int contactCount = Contacts.Count;

            Console.WriteLine("You have " + "contact".ToQuantity(contactCount));

            if (contactCount == 0)
            {
                Console.WriteLine("There is no contact added yet.");
                return;
            }

            var table = new ConsoleTable("Id", "Name", "Phone Number", "Email", "Contact Type", "Date Created");

            foreach (var contact in Contacts)
            {
                table.AddRow(contact.Id, contact.Name, contact.PhoneNumber, contact.Email, ((ContactType)contact.ContactType).Humanize(), contact.CreatedAt.Humanize());
            }

            table.Write(Format.Alternative);

        }

        
            public void UpdateContact(string phoneNumber, string name, string email)
{
    // Find the contact in the in-memory list based on the provided phone number
    var contact = FindContact(phoneNumber);

    
    if (contact is null)
    {
        Console.WriteLine("Contact does not exist!");
        return;
    }

    // Update the contact properties
    contact.Name = name;
    contact.Email = email;

    string filePath = "contact.txt";

    try
    {    
        var lines = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {

                if (line.Contains(phoneNumber))
                {
                    string updatedLine = $"{name}\t{phoneNumber}\t{email}\t{contact.ContactType}\t{contact.CreatedAt}";
                    lines.Add(updatedLine);
                }
                else
                {
                    lines.Add(line);
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var modifiedLine in lines)
            {
                writer.WriteLine(modifiedLine);
            }
        }

        Console.WriteLine("Contact updated successfully.");
    }
    catch (Exception ex)
    {
        
        Console.WriteLine($"Error while performing file operation: {ex.Message}");
       
        throw new contactException($"Error while performing file operation: {ex.Message}");
    }
}

        private void Print(Contact contact)
        {
            Console.WriteLine($"Name: {contact!.Name}\nPhone Number: {contact!.PhoneNumber}\nEmail: {contact!.Email}");
        }

        private bool IsContactExist(string phoneNumber)
        {
            return Contacts.Any(c => c.PhoneNumber == phoneNumber);
        }
        }

       
    }
