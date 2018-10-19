using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ReactjsCoreTest.Application.Interfaces;
using ReactjsCoreTest.Data.Entities;

namespace ReactjsCoreTest.Controllers
{
    public class ProductApiController : ApiController
    {
        IProductRepository<Product> _ProductRepository;

        public ProductApiController(IProductRepository<Product> ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        //GET: api/ApiProduct
       [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var listAll = await _ProductRepository.GetAllAsync();
            Console.WriteLine(listAll);
            return new OkObjectResult(listAll);
        }

        // GET: api/ApiProduct/5
        //[HttpGet("{id}", Name = "Get")]
        [HttpGet]
        public async Task<Product> GetDetails(string id)
        {
            return await _ProductRepository.FindByIdAsync(id);
        }

        // POST: api/ApiProduct
        [HttpPut]
        public async Task<IActionResult> Create(Product product)
        {
            await _ProductRepository.InsertAsync(product);

            return new OkObjectResult(product);
        }

        // PUT: api/ApiProduct/5
        [HttpGet]
        [Route("api/ProductApi/Update")]
        public async Task<IActionResult> Update(Product product)
        {
            var productFromDb = await _ProductRepository.FindByIdAsync(product.ObjectId);
            if (productFromDb == null)
                return new NotFoundResult();
            await _ProductRepository.UpdateAsync(product);
            return new OkObjectResult(product);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("api/ProductApi/Delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var IdProduct = await _ProductRepository.FindByIdAsync(id);

            if (IdProduct == null)
                return new NotFoundResult();
            await _ProductRepository.DeleteAsync(id);

            return new OkResult();
        }
    }
}
