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
    public class EditModel : PageModel
    {
        [BindProperty]
        public ContactInfo Contact { get; set; }
        private IManageContacts _contacts { get; set; }
        public EditModel(IManageContacts contacts)
        {
            _contacts = contacts;
        }

        public IActionResult OnGet(int? contactId)
        {
            Contact = contactId.HasValue ? _contacts.GetContact(contactId)
                : new ContactInfo();
            return Contact == null ? RedirectToPage("./ContactError", new
            {
                message = "اطلاعات تماسی با مشخصات داده شده یافت نشد."
            }) : (IActionResult)Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TempData["CommitMessage"] = Contact.ContactID > 0 ? "Contact Updated" : "Contact Created";
                _ = Contact.ContactID > 0 ? _contacts.UpdateContact(Contact) : _contacts.AddContact(Contact);
                _ = _contacts.Save();
                return RedirectToPage("./Detail", new { contactId = Contact.ContactID });
            }
            
            return Page();
        }

    }
}
