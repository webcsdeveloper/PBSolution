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
    public class DetailModel : PageModel
    {
        [TempData]
        public string CommitMessage { get; set; }
        public ContactInfo Contact { get; set; }
        private IManageContacts _contacts { get; set; }
        public DetailModel(IManageContacts contacts)
        {
            _contacts = contacts;
        }

        public IActionResult OnGet(int contactId)
        {
            Contact = _contacts.GetContact(contactId);
            return Contact == null ? RedirectToPage("./ContactError", new
            {
                message = "اطلاعات تماسی با مشخصات داده شده یافت نشد."
            }) : (IActionResult)Page();
        }
    }
}
