using CoreApp.Data.Enums;
using CoreApp.Data.Interfaces;
using CoreApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace CoreApp.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, ISeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public DateTime CreatedDate { set; get; }
        public DateTime ModifiedDate { set; get; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }


        public virtual ICollection<Product> Products { set; get; }
    }
}