﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int  Id { get; set; }

        [Required]
        public String Name { get; set;}

        public string  Author { get; set; }
    }
}
