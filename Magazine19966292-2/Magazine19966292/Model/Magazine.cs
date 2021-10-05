using System;
using System.ComponentModel.DataAnnotations;

namespace Magazine19966292.Model
{
    public class Magazine
    {
        public int ID { get; set; }


        [Required]
        [Display(Name = "Magazine Name")]
        [RegularExpression(@"[A-Za-z _0-9]{3,20}", ErrorMessage = "Each magazine must have a title! " +
            " Can only consists of 3-20 English letters, digits, spaces and underscore.")]
        public string MagazineName { get; set; }


        [Required]
        [Display(Name = "Price Each")]
        [Range(5, 20)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
