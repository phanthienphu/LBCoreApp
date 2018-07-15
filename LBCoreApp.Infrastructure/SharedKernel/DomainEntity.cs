using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { set; get; }

        //true if domain entity has an identity
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    } 
}
