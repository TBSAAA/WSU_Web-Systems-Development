using System;
using System.ComponentModel.DataAnnotations;

namespace Magazine19966292.Model
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Family Name")]
        [RegularExpression(@"[A-Z][a-z'-]{1,19}", ErrorMessage = "must start with a captical letter and continue with 2-20 lower-case letters or hyphen or apostrophe.")]
        public string FamilyName { get; set; }

        [Required]
        [Display(Name = "Given Name")]
        [RegularExpression(@"[A-Z][a-z'-]{1,19}", ErrorMessage = "must start with a captical letter and continue with 2-20 lower-case letters or hyphen or apostrophe.")]
        public string GivenName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birth { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^04[0-9]{2}[ ][0-9]{3}[ ][0-9]{3}$", ErrorMessage = "must follow this style 04xx xxx xxx")]
        public string Mobile { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"[0-8]{1}[0-9]{3}$", ErrorMessage = "4 digits and the first digit can't be 9")]
        public string Postal { get; set; }


    }
}
