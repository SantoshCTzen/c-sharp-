using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core_Code_First.Models
{
    public class Customer
    {
        [Key]
        public int CustomerRowId { get; set; }
        [Required]
        [StringLength(10)]
        public string CustomerId { get; set; }
        [Required]
        [StringLength(20)]
        [ConcurrencyCheck]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(30)]
        public string Address { get; set; }
        [Required]
        [StringLength(10)]
        public string City { get; set; }
        [Required]
        public int Age { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
