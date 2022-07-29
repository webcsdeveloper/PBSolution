using PB.Core;
using System;
using System.Collections.Generic;

namespace PB.Data
{
    public interface IManageContacts
    {
        IEnumerable<ContactInfo> ListContacts(string name);
        ContactInfo GetContact(int? id);
        ContactInfo UpdateContact(ContactInfo contactData);
        int Save();
        ContactInfo AddContact(ContactInfo contact);
        object DeleteContact(ContactInfo contact);

    }
}
