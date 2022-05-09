using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface IProductService
    {
<<<<<<< HEAD

=======
        Task<IEnumerable<Product>> GetProductItemsAsync();
        Task<IEnumerable<Product>> GetProductItemsByIdAsync(int id);
        Task<bool> AddProductItemsAsync(Product item);
        //Task<IEnumerable<Product>> EditProductItemsAsync();
>>>>>>> bcf3363f80441c0b48509d443dc16da632409eca
    }
}
