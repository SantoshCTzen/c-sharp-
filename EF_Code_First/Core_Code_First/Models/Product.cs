using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Core_Code_First.Models
{
    public class Product
    {
        [Key]
        public int ProductRowId { get; set; }
        [Required]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        public int VendorRowId { get; set; } 
        [Required]
        [StringLength(10)]
        [ConcurrencyCheck]
        public string ProductName { get; set; }
        [Required]
        [StringLength(10)]
        public string CategoryName { get; set; }
        [Required]
        public int UnitPrice { get; set; }

        public Vendor Vendor { get; set; }
    }
}
