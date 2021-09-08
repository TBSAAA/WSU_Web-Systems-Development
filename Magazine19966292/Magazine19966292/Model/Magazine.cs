using System;
using System.ComponentModel.DataAnnotations;

namespace Magazine19966292.Model
{
    public class Magazine
    {
        public int ID { get; set; }
        public string MagazineName { get; set; }
        public decimal Price { get; set; }
    }
}
