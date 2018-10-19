using MongoDB.Driver;
using ReactjsCoreTest.Application.Interfaces;
using ReactjsCoreTest.Data.Entities;
using ReactjsCoreTest.Infrastrusture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReactjsCoreTest.Application.Implementation
{
    public class ProductRepository : IProductRepository<Product>
    {
        private readonly IDBContext _context;
        public ProductRepository(IDBContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteAsync(string id)
        {
            Product Product = await FindByIdAsync(id);
            if (Product is null)
                return false;
            DeleteResult result = await _context.Products.DeleteOneAsync(x => x.ObjectId == Product.ObjectId);
            return result.DeletedCount > 0;
        }

        public Task<ICollection<Product>> FindAllAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> FindByIdAsync(string id)
        {
            return await _context.Products.Find(x => x.ObjectId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.Find(_ => true).ToListAsync();
        }

        public async Task InsertAsync(Product entity)
        {
            await _context.Products.InsertOneAsync(entity);
        }

        public  Task<bool> Update(Product entity)
        {
            throw new NotImplementedException();
            //var updateResult = _context.Products.ReplaceOneAsync<Product>(x => x.GuiId == entity.GuiId, entity);
            //return updateResult.IsAcknowledged && updateResult.MatchedCount > 0;
        }

        public async Task<bool> UpdateAsync(Product entity)
        {

            ReplaceOneResult updateResult =
                await _context.Products.ReplaceOneAsync(filter: x => x.ObjectId == entity.ObjectId, replacement: entity);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }
    }
}
