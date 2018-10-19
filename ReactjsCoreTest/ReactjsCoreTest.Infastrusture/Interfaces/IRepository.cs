using ReactjsCoreTest.Infrastrusture.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReactjsCoreTest.Infrastrusture.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> DeleteAsync(string id);
        Task<T> FindByIdAsync(string id);

        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> predicate);

        Task InsertAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> Update(T entity);

    }
}