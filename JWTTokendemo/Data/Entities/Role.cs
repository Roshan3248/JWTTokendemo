using System.ComponentModel.DataAnnotations;

namespace JWTTokendemo.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
