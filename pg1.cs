using System;
using System.Collections.Generic;

class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}

class AddressBook
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact()
    {
        Contact newContact = new Contact();

        Console.Write("1.Enter First Name: ");
        newContact.FirstName = Console.ReadLine();

        Console.Write("2.Enter Last Name: ");
        newContact.LastName = Console.ReadLine();

        Console.Write("3.Enter Address: ");
        newContact.Address = Console.ReadLine();

        Console.Write("4.Enter City: ");
        newContact.City = Console.ReadLine();

        Console.Write("5.Enter State: ");
        newContact.State = Console.ReadLine();

        Console.Write("6.Enter Phone Number: ");
        newContact.PhoneNumber = Console.ReadLine();

        Console.Write("7.Enter Email: ");
        newContact.Email = Console.ReadLine();

        contacts.Add(newContact);

        Console.Clear();
        Console.WriteLine("Contact Added Successfully");
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Contacts:\n");

        foreach (var contact in contacts)
        {
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Address: {contact.Address}, {contact.City}, {contact.State}");
            Console.WriteLine($"Phone: {contact.PhoneNumber}");
            Console.WriteLine($"Email: {contact.Email}\n");
        }

        Console.ReadLine();
        Console.Clear();
    }

    public void EditContact(string firstName)
    {
        Contact existingContact = null;

        foreach (Contact c in contacts)
        {
            if (c.FirstName.Equals(firstName))
            {
                existingContact = c;

                if (existingContact == null)
                {
                    Console.WriteLine("Contact not found.");
                }
                else
                {
                    DisplayContact(existingContact);

                    Console.Write("\nEnter the option to edit: ");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("1.Enter the New First Name: ");
                            existingContact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("2.Enter the New Last Name: ");
                            existingContact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("3.Enter the New Address: ");
                            existingContact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("4.Enter the New City: ");
                            existingContact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("5.Enter the New state: ");
                            existingContact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("6.Enter the New PhoneNo: ");
                            existingContact.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.Write("7.Enter the New Email: ");
                            existingContact.Email = Console.ReadLine();
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine("Contact Edited Successfully.");
                }
            }
        }
    }

    public void DeleteContact(string email)
    {
        Contact existingContact = null;

        foreach (Contact c in contacts)
        {
            if (c.Email.Equals(email))
            {
                existingContact = c;
                break;
            }
        }

        if (existingContact == null)
        {
            Console.WriteLine("Contact not found");
        }
        else
        {
            contacts.Remove(existingContact);
            Console.Clear();
            Console.WriteLine("Contact deleted successfully");
        }
    }

    private void DisplayContact(Contact contact)
    {
        Console.WriteLine($"First Name: {contact.FirstName}");
        Console.WriteLine($"Last Name: {contact.LastName}");
        Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
        Console.WriteLine($"Email: {contact.Email}");
        Console.WriteLine($"Address: {contact.Address}");
        Console.WriteLine($"City: {contact.City}");
        Console.WriteLine($"State: {contact.State}\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book.");

        AddressBook addressBook = new AddressBook();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Enter an Option to perform : ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    addressBook.AddContact();
                    break;
                case 2:
                    Console.Clear();
                    addressBook.DisplayContacts();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Enter the First Name of the contact to edit: ");
                    string editFirstName = Console.ReadLine();
                    addressBook.EditContact(editFirstName);
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Enter the Email of the contact to delete: ");
                    string deleteEmail = Console.ReadLine();
                    addressBook.DeleteContact(deleteEmail);
                    break;
                case 5:
                    isRunning = false;
                    break;
            }
        }
    }
}




