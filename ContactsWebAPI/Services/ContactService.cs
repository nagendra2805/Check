using ContactsWebAPI.Interfaces;
using ContactsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWebAPI.Services
{
    public class ContactService : IContactService
    {
        private readonly List<Contact> contacts;
        public ContactService()
        {
            contacts = new List<Contact>();
        }

        public async Task<List<Contact>> CreateContact(Contact contact)
        {
            var existedcontact = contacts.Find(x => x.FirstName == contact.FirstName && x.LastName == contact.LastName);

            if (existedcontact != null)
                contacts[contacts.IndexOf(existedcontact)] = contact;
            else
                contacts.Add(contact);

            return contacts;
        }
    }
}
