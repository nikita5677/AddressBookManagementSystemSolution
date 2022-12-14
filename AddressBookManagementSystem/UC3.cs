using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    //created a Edit class
    class Edit
    {

        Dictionary<string, Contact> dictionary = new Dictionary<string, Contact>();
        public static List<Contact> contacts = new List<Contact>();
        // created a contact class
        public class Contact
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public long Phonenumber { get; set; }
            public int Zipcode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Email { get; set; }
        }
        // created a  method  for add the person details
        public static void AddPerson()
        {
            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.Lastname = Console.ReadLine();

            Console.Write("enter the Phone number: ");
            contact.Phonenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the zipcode: ");
            contact.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the city: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter the state: ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter the email:");
            contact.Email = Console.ReadLine();

            contacts.Add(contact);
        }
        // created a method for list the person
        public static void listPerson()
        {
            foreach (var data in contacts)
            {
                Console.WriteLine(data.Firstname);
                Console.WriteLine(data.Lastname);
                Console.WriteLine(data.Phonenumber);
                Console.WriteLine(data.City);
                Console.WriteLine(data.State);
                Console.WriteLine(data.Zipcode);
                Console.WriteLine(data.Email);

            }
        }
        // created a method for edit the person details
        public static void EditPerson()
        {
            Console.Write("enter the name to edit: ");
            string editname = Console.ReadLine();
            foreach (var data in contacts)
            {
                if (contacts.Contains(data))
                {
                    if (data.Firstname == editname)
                    {
                        Console.Write("enter the Phone number: ");
                        data.Phonenumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the zipcode: ");
                        data.Zipcode = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the city: ");
                        data.City = Console.ReadLine();
                    }
                }
            }
        }

        //created for a new contact user
        public Dictionary<string, Contact> NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();

            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.Lastname = Console.ReadLine();

            Console.Write("enter the Phone number: ");
            contact.Phonenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the city: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter the zipcode: ");
            contact.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the state: ");
            contact.State = (Console.ReadLine());

            Console.Write("Enter the email: ");
            contact.Email = (Console.ReadLine());


            contacts.Add(contact);
            dictionary.Add(Bookname, contact);

            return null;
        }

        // craeted an another method for display the data
        public void Display()
        {
            foreach (KeyValuePair<string, Contact> pair in dictionary)
            {
                Console.WriteLine("Address Book Name " + pair.Key);
                foreach (var kvp in dictionary.Values)
                {
                    Console.WriteLine("First Name: " + kvp.Firstname);
                    Console.WriteLine("Last Name: " + kvp.Lastname);
                    Console.WriteLine("City : " + kvp.City);
                    Console.WriteLine("State : " + kvp.State);
                    Console.WriteLine("Zip : " + kvp.Zipcode);
                    Console.WriteLine("Phone Number: " + kvp.Phonenumber);
                    Console.WriteLine("Email: " + kvp.Email);
                }
            }
        }
    }
}