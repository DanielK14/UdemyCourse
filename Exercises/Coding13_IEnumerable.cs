﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This time, you have to create Contact and PhoneBook classes in the right way that will allow you to run the Main method we provided.

You have to use this list of Contact:

    Contacts = new List<Contact>{
                    new Contact("Andre", "435797087"),
                    new Contact("Lisa", "435677087"),
                    new Contact("Dine", "3457697087"),
                    new Contact("Sofi", "4367697087")
                };

The method Call should print "Calling to X. Phone number is Y" where X is a name and Y is a phone number.
*/

namespace UdemyCourse.Exercises
{
    internal class Coding13_IEnumerable
    {
        public class Contact
        {
            public string Name { get; set; }
            public string Phone { get; set; }

            public Contact(string name, string phone)
            {
                Name = name;
                Phone = phone;
            }

            public void Call()
            {
                Console.WriteLine("Calling to {0}. Phone number is {1}", Name, Phone);
            }
        }

        public class PhoneBook : IEnumerable<Contact>
        {
            public List<Contact> Contacts;

            public PhoneBook()
            {
                Contacts = new List<Contact>{
                    new Contact("Andre", "435797087"),
                    new Contact("Lisa", "435677087"),
                    new Contact("Dine", "3457697087"),
                    new Contact("Sofi", "4367697087")
                };
            }

            IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
            {
                return Contacts.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        // TODO

        public static class Program
        {
            static public void Main(string[] args)
            {
                PhoneBook MyPhoneBook = new PhoneBook();

                foreach (Contact contact in MyPhoneBook)
                {
                    contact.Call();
                }
            }
        }
    }
}
