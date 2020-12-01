using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _pucblicProductService;
        public ProductController(IPublicProductService puclicProductService)
        {
            _pucblicProductService = puclicProductService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _pucblicProductService.GetAll();
            return Ok(products);
        }
    }
}
