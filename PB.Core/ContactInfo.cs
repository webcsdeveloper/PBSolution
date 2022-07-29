using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PB.Core
{
    public class ContactInfo : IValidatableObject
    {
        [Key]
        public int ContactID { get; set; }
        [DisplayName("نام")]
        public string FirstName { get; set; }
        [Required, DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string PersonalCode { get; set; }
        //public int CPID { get; set; }
        public string CPNo { get; set; }
        //public int WAddrID { get; set; }
        public string WAddrDesc { get; set; }
        public string WPhoneNo { get; set; }
        public string WInternalNo { get; set; }
        public string WPostalCode { get; set; }
        //public int RoleID { get; set; }
        public string Organization { get; set; }
        public string Unit { get; set; }
        public string Role { get; set; }
        //public int HAddrID { get; set; }
        public string HAddrDesc { get; set; }
        public string HPhoneNo { get; set; }
        public string HPostalCode { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();
            if (string.IsNullOrEmpty(FirstName))
            {
                validationResults.Add(new ValidationResult("پر کردن این فیل الزامی است", new[] { nameof(FirstName) }));
            }
            return validationResults;
        }
        //public int WAddrID { get; set; }
    }
}
