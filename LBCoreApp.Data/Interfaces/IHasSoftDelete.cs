using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Data.Interfaces
{
    interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
