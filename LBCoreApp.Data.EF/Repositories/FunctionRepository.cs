using LBCoreApp.Data.Entities;
using LBCoreApp.Data.IRepositories;
using System;

namespace LBCoreApp.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}