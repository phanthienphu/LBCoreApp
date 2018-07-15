using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Data.Interfaces
{
    interface IMultiLanguage<T>
    {
        T LanguageId { set; get; }
    }
}
