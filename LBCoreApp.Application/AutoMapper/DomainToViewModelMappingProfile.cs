using AutoMapper;
using LBCoreApp.Application.ViewModels.Product;
using LBCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
