using LBCoreApp.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}
