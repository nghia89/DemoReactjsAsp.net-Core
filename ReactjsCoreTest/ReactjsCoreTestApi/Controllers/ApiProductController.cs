using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ReactjsCoreTest.Application.Interfaces;
using ReactjsCoreTest.Data.Entities;

namespace ReactjsCoreTestApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ApiProductController : Controller
    {
     private readonly IProductRepository<Product> _ProductRepository;

        public ApiProductController(IProductRepository<Product> ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        // GET: api/ApiProduct
        [HttpGet]
        [Route("api/ApiProduct/Index")]
        public async Task<IActionResult> GetAll()
        {
         var listAll =  await _ProductRepository.GetAllAsync();
            return new OkObjectResult(listAll);
        }

        // GET: api/ApiProduct/5
        //[HttpGet("{id}", Name = "Get")]
        [HttpGet]
        [Route("api/ApiProduct/GetDetails/{id}")]
        public async Task<Product> GetDetails(string id)
        {
            return await _ProductRepository.FindByIdAsync(id);
        }

        // POST: api/ApiProduct
        [HttpPut]
        [Route("api/ApiProduct/Create")]
        public async Task<IActionResult> Create(Product product)
        {
            await _ProductRepository.InsertAsync(product);

            return new OkObjectResult(product);
        }

        // PUT: api/ApiProduct/5
        [HttpGet]
        [Route("api/ApiProduct/Update")]
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
        [Route("api/ApiProduct/Delete/{id}")]
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
