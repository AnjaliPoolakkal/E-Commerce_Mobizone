using ProductCatalog.Domain.Customers;
using ProductCatalog.EFRepository;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject.Admin
{
      public class CatalogUserBO : ICatalogUserBO
    
        {
        private readonly ICatalogUserRepository catalogUserRepository;

        public CatalogUserBO(ICatalogUserRepository catalogItemRepository)
        {
            this.catalogUserRepository = catalogItemRepository;
        }

        public async Task<IEnumerable<User>> GetUser()
        {
            return await catalogUserRepository.GetAll();
        }
    }
}

