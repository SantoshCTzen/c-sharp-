﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cs_Assignment.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        [StringLength(20)]
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }

    }
}
