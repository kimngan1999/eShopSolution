﻿using eShopSolution.Application.catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
