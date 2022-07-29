using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using PB.Core;

namespace PB.Data
{
	public class SQLData : IManageContacts
	{
		private readonly ContactDbContext _database;
		public SQLData(ContactDbContext database) => _database = database;

        public ContactInfo AddContact(ContactInfo contact)
        {
            _ = _database.Add(contact);
            return contact;
        }

        public ContactInfo GetContact(int? id) => _database.Contacts.Find(id);

		public IEnumerable<ContactInfo> ListContacts(string name) => _database.Contacts
			.Where(x => string.IsNullOrEmpty(name)
			|| x.FirstName.Contains(name) || x.LastName.Contains(name))
			.OrderBy(x => x.ContactID);


		

        public ContactInfo UpdateContact(ContactInfo contactData)
		{
			var entity = _database.Contacts.Attach(contactData);
			// tells EF that something on the Contact entity has changed.
			entity.State = EntityState.Modified;
			return contactData;
		}

		public int Save() => _database.SaveChanges();

        public object DeleteContact(ContactInfo contact)
        {
			var entity = _database.Remove(contact);
			return entity;
        }
    }
}

