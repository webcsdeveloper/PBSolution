using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PB.Core;
using PB.Data;


namespace PB.Pages.Contacts
{
    public class ListContactsModel : PageModel
    {
        private readonly IManageContacts _contact;
        public IEnumerable<ContactInfo> Contacts;

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        public ListContactsModel(IManageContacts contact)
        {
            _contact = contact;
        }

        public void OnGet()
        {
            Contacts = _contact.ListContacts(SearchQuery); 
            
        }
    }
}
