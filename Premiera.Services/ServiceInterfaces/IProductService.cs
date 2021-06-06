using Primera.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Premiera.Services.ServiceInterfaces
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductModel product);

    }
}
