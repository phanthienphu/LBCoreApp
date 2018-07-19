using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LBCoreApp.Data.Enums;
using LBCoreApp.Data.Interfaces;
using LBCoreApp.Infrastructure.SharedKernel;

namespace LBCoreApp.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>,
        IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        // trường hợp khóa ngoại ICollection<Product> null
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        //lớp khởi tạo cho automapper
        public ProductCategory(string name, string description, int? parentId, int? homeOrder, 
            string image, bool? homeFlag,int sortOrder,Status status,string seoPageTitle, string seoAlias,
            string seoKeyword, string seoDescription)
        {
            Name = name;
            Description = description;
            ParentId = parentId;
            HomeOrder = homeOrder;
            Image = image;
            HomeFlag = homeFlag;
            SortOrder = sortOrder;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeyword;
            SeoDescription = seoDescription;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}