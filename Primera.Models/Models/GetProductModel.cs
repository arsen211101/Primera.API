using System;
using System.Collections.Generic;
using System.Text;

namespace Primera.Models.Models
{
    public class GetProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
