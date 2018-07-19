using LBCoreApp.Data.Entities;
using LBCoreApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace LBCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}