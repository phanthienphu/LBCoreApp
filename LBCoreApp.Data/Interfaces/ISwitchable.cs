using LBCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
