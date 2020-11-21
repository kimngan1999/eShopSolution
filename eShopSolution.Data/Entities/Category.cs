using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        private int Id { set; get; }
        private int SortOrder { set; get; }
        private Boolean IsShowOnHome { set; get; }
        private int? ParentId { set; get; }
        private Status Status { set; get; }


    }
}
