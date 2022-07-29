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
    public class DeleteContactModel : PageModel
    {
        private IManageContacts  _contacts;
        public ContactInfo Contact { get; set; }
        public bool IsDBChanged { get; set; }
        public DeleteContactModel(IManageContacts contacts)
        {
            _contacts = contacts;
            IsDBChanged = false;
            
        }

        public void OnGet(int contactId)
        {
            Contact = _contacts.GetContact(contactId);
        }
        public void OnPost(int contactId)
        {
            Contact = _contacts.GetContact(contactId);
            if (Contact != null)
            {
                _ = _contacts.DeleteContact(Contact);
                if (_contacts.Save() >= 0)
                {
                    IsDBChanged = true;
                }
            }
            else
            {
                RedirectToPage("./ContactError", new
                {
                    message = "اطلاعات تماسی با مشخصات داده شده یافت نشد."
                });
            }
            
        }
    }
}
