using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        private int Id { set; get; }
        private decimal Price { set; get; }
        private decimal OriginalPrice { set; get; }
        private int Stock { set; get; }
        private int ViewCount { set; get; }
        private DateTime DateCreated { set; get; }
        private String SeoAlias { set; get; }

    }
}
