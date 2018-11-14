using LBCoreApp.Data.Entities;
using LBCoreApp.Data.IRepositories;

namespace LBCoreApp.Data.EF.Repositories
{
    public class ProductTagRepository : EFRepository<ProductTag, int>, IProductTagRepository
    {
        public ProductTagRepository(AppDbContext context) : base(context)
        {
        }
    }
}