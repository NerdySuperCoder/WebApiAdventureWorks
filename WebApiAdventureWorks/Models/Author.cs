﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiAdventureWorks.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}