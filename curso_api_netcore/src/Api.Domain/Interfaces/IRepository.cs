using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync (T item);
        Task<T> UpdateAsync (T item);
        Task<bool> DeleteAsync (Guid Id);
        Task<T> SelectAsync (Guid Id);
        Task<IEnumerable<T>> SelectAsync ();
        Task<bool> ExistAsync (Guid id);
    }
}
