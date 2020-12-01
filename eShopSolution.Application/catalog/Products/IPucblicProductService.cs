using eShopSolution.Application.catalog.Dtos;
using eShopSolution.Application.catalog.Products.Dtos;
using eShopSolution.Application.catalog.Products.Dtos.Public;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.catalog.Products
{
     public interface IPucblicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    } 
}
