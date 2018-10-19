using Microsoft.AspNetCore.Mvc;
using ReactjsCoreTest.Application.Interfaces;
using ReactjsCoreTest.Data.Entities;
using ReactjsCoreTest.Infrastrusture.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReactjsCoreTest.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository<Product> _productRepository;

        public ProductController(IProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IActionResult> Index()
        {
            var id = await _productRepository.GetAllAsync();
            return View(id);
        }
        public async Task<IActionResult> Delete(string id)
        {
            await _productRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
         await _productRepository.InsertAsync(product);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string id)
        {
            Product list = await _productRepository.FindByIdAsync(id);
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            await _productRepository.UpdateAsync(product);

            return RedirectToAction("Index");
        }
    }
}