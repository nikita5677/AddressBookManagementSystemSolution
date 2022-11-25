﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Problem");
            Person person = new Person();
            while (true)
            {
                Console.WriteLine("Please enter a command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Entered Command is " + command);

                if (command == "add")
                {
                    Person.AddPerson();
                }
                if (command == "view")
                {
                    Person.listPerson();
                }
                if (command == "UniqueBookName")
                {
                    person.NewUser();
                }

                if (command == "ViewDictionary")
                {
                    person.Display();
                }
            }

        }
    }
}