using AutoMapper;
using Premiera.Domain.Domain;
using Primera.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Premiera.Helpers.Mappers
{
    public class ProductMapper:Profile
    {
        public ProductMapper()
        {
            CreateMap<CreateProductModel, ProductDomain>();

            CreateMap<ProductDomain, GetProductModel>();
        }
    }
}
