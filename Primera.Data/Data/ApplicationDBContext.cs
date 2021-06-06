using Microsoft.EntityFrameworkCore;
using Premiera.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Premiera.Data.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public virtual DbSet<ProductDomain> Product { get; set; }
    }
}
