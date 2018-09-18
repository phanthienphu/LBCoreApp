using LBCoreApp.Data.Entities;
using LBCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Data.EF.Repositories
{
    public class ProductRepository:EFRepository<Product,int>,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) 
        {

        }
    }
}
