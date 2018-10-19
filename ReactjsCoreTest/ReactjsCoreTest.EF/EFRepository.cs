using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using ReactjsCoreTest.Infrastrusture.Interfaces;
using ReactjsCoreTest.Infrastrusture.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReactjsCoreTest.EF
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync( T entity)
        {
            throw new NotImplementedException();
        }
    }
}
