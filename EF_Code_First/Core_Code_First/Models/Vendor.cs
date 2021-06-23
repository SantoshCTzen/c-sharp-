using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Core_Code_First.Models
{
    public class Vendor
    {
        [Key]
        public int VendorRowId { get; set; }
        [Required]
        [StringLength(10)]
        public string VendorId { get; set; }
        [Required]
        [StringLength(20)]
        [ConcurrencyCheck]
        public string VendorName { get; set; }
          [Required]
          [StringLength(30)]
          public string Address { get; set; }
          [Required]
          [StringLength(30)]
          public string City { get; set; }

          [Required]
          [StringLength(30)]
          public string Email { get; set; } 

        public ICollection<Product> Products { get; set; }
    }
}
