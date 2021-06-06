using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Premiera.Domain.Domain
{
    public class ProductDomain
    {
        [Key]
        public int Id { get;  set; }

        [Column("Name", TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        [Column("Description", TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        [Column("Count", TypeName = "int")]
        public int Count { get; set; }
        [Column("Price", TypeName = "decimal")]
        public decimal Price { get; set; }

        [Column("CreateDate", TypeName="datetime")]
        public DateTime CreateDate { get;  set; }
    }
}
