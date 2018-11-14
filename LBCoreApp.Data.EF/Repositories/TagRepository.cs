using LBCoreApp.Data.Entities;
using LBCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Data.EF.Repositories
{
    public class TagRepository : EFRepository<Tag,string>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context)
        {
        }
    }
}
