using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4.Infrastructure.Data.Interfaces
{
    public interface IUnitOfWork
    {
        void Dispose();
        Task<int> SaveAsync();
        //void Dispose(bool disposing);
        IRepository<T> Repository<T>() where T : class;
    }
}
