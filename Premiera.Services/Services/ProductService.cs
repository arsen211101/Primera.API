using AutoMapper;
using Premiera.Domain.Domain;
using Premiera.Repositories.RepositoryInterfaces;
using Premiera.Services.ServiceInterfaces;
using Primera.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Premiera.Services.Services
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }


        public async Task CreateProduct(CreateProductModel product)
        {
            try
            {
                await _productRepository.CreateProduct(_mapper.Map<CreateProductModel, ProductDomain>(product));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
