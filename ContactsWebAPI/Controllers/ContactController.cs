using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private List<ContactModel> ContactList;


        public ContactController()
        {
            ContactList = new List<ContactModel>();
        }


        
        [HttpPost]
        [Route("CreateorUpdateContact")]
        public async Task<IActionResult> Post([FromBody] ContactModel contact)
        {
            if (contact == null)
                return BadRequest(contact);

            var existedcontact = ContactList.Find(x => x.FirstName == contact.FirstName && x.LastName == contact.LastName);

            if (existedcontact != null)
                ContactList[ContactList.IndexOf(existedcontact)] = contact;
            else
                ContactList.Add(contact);

            return Ok(ContactList);
        }

    }
}
