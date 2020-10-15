using ContactsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWebAPI.Interfaces
{
    public interface IContactService
    {
        Task<List<ContactModel>> CreateContact(ContactModel contact);
    }
}
