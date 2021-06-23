using System.ComponentModel.DataAnnotations;

namespace Cs_Assignment.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(30)]

        public string Email { get; set; }
        [StringLength(15)]

        public string Password { get; set; }
        [Required]
        public int RoleId { get; set; }

        public Roles Roles { get; set; }
    }
}
