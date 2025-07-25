﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
