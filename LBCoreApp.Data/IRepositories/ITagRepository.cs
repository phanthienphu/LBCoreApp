using LBCoreApp.Data.Entities;
using LBCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Data.IRepositories
{
    public interface ITagRepository : IRepository<Tag,string>
    {
    }
}
