using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Magazine19966292.Model
{
    public class MagazinePurchase
    {
        [Required]
        [Display(Name = "Magazine Title")]
        public string MagazineTitle { get; set; }

        [Required]
        [Display(Name = "Number of Magazines")]
        [Range(1, 10)]
        public int MagazineCount { get; set; }

        [Required]
        [Display(Name = "Credit Card Number")]
        [DataType(DataType.CreditCard)]
        [RegularExpression(@"[0-9]{16}$", ErrorMessage = "The credit card number must has 16 digits")]
        public string CreditCardNum { get; set; }
    }
}
