﻿using System.ComponentModel.DataAnnotations;

namespace ProjectApp.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
