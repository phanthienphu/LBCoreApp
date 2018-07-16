﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Call save change from db context
        void Commit();
    }
}
