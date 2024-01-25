using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    class Addressbook
    {
        class Contact
        {
            
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public string Phoneno { get; set; }
            public string Email { get; set; }
        }

        static void Main()
        {
            List<Contact> Addressbook = new List<Contact>();
            Contact NewContact = new Contact();

            Console.WriteLine("Welcome to Addressbook");
            Console.WriteLine("Enter Your contact details");

            Console.Write("Enter the First name:");
            NewContact.First_Name = Console.ReadLine();

            Console.Write("Enter the Last Name:");
            NewContact.Last_Name = Console.ReadLine();

            Console.Write("Enter the address:");
            NewContact.Address = Console.ReadLine();

            Console.Write("Enter the city:");
            NewContact.City = Console.ReadLine();

            Console.Write("Enter the zip:");
            NewContact.Zip = Console.ReadLine();

            Console.Write("Enter the email:");
            NewContact.Email = Console.ReadLine();

            Console.Write("Enter the phoneno:");
            NewContact.Phoneno = Console.ReadLine();

            

            Addressbook.Add(NewContact);
            
            Console.WriteLine("Contact added successfully:");
            Console.WriteLine($"First_Name: {NewContact.First_Name}");
            Console.WriteLine($"Last_Name: {NewContact.Last_Name}");
            Console.WriteLine($"City: {NewContact.City}");
            Console.WriteLine($"Zip: {NewContact.Zip}");
            Console.WriteLine($"Phone Number: {NewContact.Phoneno}");
            Console.WriteLine($"Email: {NewContact.Email}");
            Console.ReadLine();
        }
    }
}

        



    
    


            



        
          

        
    