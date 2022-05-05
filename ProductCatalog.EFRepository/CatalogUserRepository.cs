using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.Customers;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class CatalogUserRepository : GenericRepository<User>, ICatalogUserRepository
    {
        private readonly CatalogDBContext context;

        public CatalogUserRepository(CatalogDBContext context) : base(context)
        {
            this.context = context;
        }
        public async override Task<IEnumerable<User>> GetAll()
        {
            return await context.User.ToListAsync();
        }
    }

}
