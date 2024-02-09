﻿using Assignmentfour.Entities;
using Assignmentfour.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentfour.Services
{
    internal class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoryService _categoryService;

        public ProductService(ProductRepository productRepository, CategoryService categoryService)
        {
            _productRepository = productRepository;
            _categoryService = categoryService;
        }

        public ProductEntity CreateProduct(string title, decimal price, string categoryName)
        {
            var categoryEntity = _categoryService.CreateCategory(categoryName);
            var productEntity = new ProductEntity
            {
                Title = title,
                Price = price,
                CategoryId = categoryEntity.Id,
            };

            productEntity =_productRepository.Create(productEntity);
            return productEntity;
        }


        public ProductEntity GetProductById(int id)
        {
            var ProductEntity = _productRepository.Get(x => x.Id == id);
            return ProductEntity;
        }

        public IEnumerable<ProductEntity> GetProducts()
        {
            var products = _productRepository.GetAll();
            return products;
        }

        public ProductEntity UpdateProduct(ProductEntity ProductEntity)
        {
            var updatedProductEntity = _productRepository.Update(x => x.Id == ProductEntity.Id, ProductEntity);
            return updatedProductEntity;
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(x => x.Id == id);
        }
    }
}
