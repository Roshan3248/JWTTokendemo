using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace JWTTokendemo.Data.Entities
{
    [Index(nameof(Email), Name = "IX_Unique_Email", IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }
        [MaxLength(20)]
        public string? Lastname { get; set; }

        [MaxLength(20)]
        [Required]
        public string Password { get; set; }

        [MaxLength(20)]
        [Required]
        public string Mobile { get; set; }

    }
}
