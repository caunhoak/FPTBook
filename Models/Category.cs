﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Genre can not be null")]
        [StringLength(255)]
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}
