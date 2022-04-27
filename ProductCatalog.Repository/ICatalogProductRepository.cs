﻿using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Repository
{
    public interface ICatalogProductRepository
    {
        Task<IEnumerable<Product>> GetProduct(int id);
        Task<Product> Add(Product item);
        Task Delete(int id);
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task Update(Product item);
    }
}
