﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Of_Work.Core;
using Unit_Of_Work.Infrastructure.Interfaces;

namespace Unit_Of_Work.Infrastructure.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductRepository _repository;

        public ProductRepository(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetaAll()
        {
            //var products = await _repository.
        }

        public Task<Product> GetaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Product model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

       
        public Task Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
