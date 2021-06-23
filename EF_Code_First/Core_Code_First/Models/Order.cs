using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Core_Code_First.Models
{
    public class Order
    {
        [Key]
        public int OrderRowId { get; set; }
        [Required]
        [StringLength(10)]
        public string OrderId { get; set; }
        [Required]
        public int ProductRowId { get; set; }
        [Required]
        public int CustomerRowId { get; set; } // Foreign key from Customer class
        [Required]
        public int Quentity { get; set; }
        [Required]
        public int TotalPrice { get; set; }

        public Customer Customer { get; set; }
    }
}
