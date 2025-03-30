using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(200)]
        public string PasswordHash { get; set; }


        [Required] 
        public string Role { get; set; } = "User";
    }
}
