﻿using System.ComponentModel.DataAnnotations;

namespace JWTTokendemo.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
