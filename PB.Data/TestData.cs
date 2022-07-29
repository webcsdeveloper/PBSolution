using PB.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB.Data
{    
    public class TestData : IManageContacts
    {
        private readonly List<ContactInfo> _contactInfos;

        public TestData()
        {
            _contactInfos = new List<ContactInfo>()
            {
                new ContactInfo{ ContactID=1, FirstName="Farhad", LastName="Badalkhani", PersonalCode="291361", NationalCode="4285645629",
                    Role="IT Security", CPNo="9128413779", HAddrDesc="niksazan", HPhoneNo="2433785408", HPostalCode="4510000000",
                    Organization="اداره کل زنجان", Unit="حراست", WAddrDesc="اداره کل تامین اجتمعی استان رنجان", WPhoneNo="33785408",
                    WPostalCode="4510000000", WInternalNo="239"},
                new ContactInfo{ ContactID=2, FirstName="Ali", LastName="Mohammadi", PersonalCode="291288", NationalCode="4280000000",
                    Role="IT Security", CPNo="9128413779", HAddrDesc="niksazan", HPhoneNo="2433785408", HPostalCode="4510000000",
                    Organization="اداره کل زنجان", Unit="حراست", WAddrDesc="اداره کل تامین اجتمعی استان رنجان", WPhoneNo="33785408",
                    WPostalCode="4510000000", WInternalNo="238"}
            };

        }

        public ContactInfo GetContact(int? id) => _contactInfos.SingleOrDefault(x => x.ContactID == id);

        public IEnumerable<ContactInfo> ListContacts(string name = null) => _contactInfos
            .Where(x => string.IsNullOrEmpty(name)
            || x.FirstName.Contains(name, StringComparison.CurrentCultureIgnoreCase) || x.LastName.Contains(name, StringComparison.CurrentCultureIgnoreCase))
            .OrderBy(x => x.ContactID);
        public ContactInfo UpdateContact(ContactInfo updatedContactData)
        {
            var dbObj = _contactInfos.SingleOrDefault(x => x.ContactID == updatedContactData.ContactID);
            if (dbObj != null)
            {
                dbObj.CPNo = updatedContactData.CPNo;
                dbObj.FirstName= updatedContactData.FirstName;
                dbObj.HAddrDesc = updatedContactData.HAddrDesc;
                dbObj.HPhoneNo = updatedContactData.HPhoneNo;
                dbObj.HPostalCode = updatedContactData.HPostalCode;
                dbObj.LastName = updatedContactData.LastName;
                dbObj.NationalCode = updatedContactData.NationalCode;
                dbObj.Organization = updatedContactData.Organization;
                dbObj.PersonalCode = updatedContactData.PersonalCode;
                dbObj.Role = updatedContactData.Role;
                dbObj.Unit = updatedContactData.Unit;
                dbObj.WAddrDesc = updatedContactData.WAddrDesc;
                dbObj.WInternalNo = updatedContactData.WInternalNo;
                dbObj.WPhoneNo = updatedContactData.WPhoneNo;
                dbObj.WPostalCode = updatedContactData.WPostalCode;
            }
            return dbObj;
        }
        public int Save() => 0;

        public ContactInfo AddContact(ContactInfo newContact)
        {
            newContact.ContactID = _contactInfos.Max(x => x.ContactID) + 1;
            _contactInfos.Add(newContact);
            return newContact;
        }

        public object DeleteContact(ContactInfo contact)
        {
            throw new NotImplementedException();
        }
    }
}
