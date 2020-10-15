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
        private readonly List<ContactModel> contacts;
        public ContactService()
        {
            contacts = new List<ContactModel>();
        }

        public async Task<List<ContactModel>> CreateContact(ContactModel contact)
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
