using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Primera.Models.Models
{
    public class CreateProductModel
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
