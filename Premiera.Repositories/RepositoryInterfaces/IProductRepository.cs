using Premiera.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Premiera.Repositories.RepositoryInterfaces
{
    public interface IProductRepository
    {
        Task CreateProduct(ProductDomain productDomain);

    }
}
