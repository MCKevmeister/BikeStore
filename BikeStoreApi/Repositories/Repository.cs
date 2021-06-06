using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BikeStoreApi.Repositories
{
    public abstract class Repository : IRepository
    {
        
        public void Dispose ()
        {
            GC.SuppressFinalize(this);
        }
    }   
}