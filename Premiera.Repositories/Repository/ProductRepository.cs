using Premiera.Data.Data;
using Premiera.Domain.Domain;
using Premiera.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Premiera.Repositories.Repository
{
    internal class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _contex;
        public ProductRepository(ApplicationDBContext context)
        {
            _contex = context;
        }
        public async Task CreateProduct(ProductDomain productDomain)
        {
            await _contex.Product.AddAsync(productDomain);
            await _contex.SaveChangesAsync();

        }
    }
}
