using Microsoft.AspNetCore.Mvc;
using Premiera.Services.ServiceInterfaces;
using Primera.Models.Models;
using System.Net;

namespace Primera.API.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        ///  With this method we can Create Product
        /// </summary>
        /// <param name="product"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Somthing not found</response>
        [HttpPost]
        [Route("CreateNewProduct")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult CreateProduct(CreateProductModel product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

    }
}
