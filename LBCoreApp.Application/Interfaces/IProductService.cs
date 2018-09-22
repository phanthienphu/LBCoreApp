using LBCoreApp.Application.ViewModels.Product;
using LBCoreApp.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}
