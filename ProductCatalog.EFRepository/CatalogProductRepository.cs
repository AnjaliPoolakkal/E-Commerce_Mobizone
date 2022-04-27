using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Products;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class CatalogProductRepository : GenericRepository<Product>, ICatalogProductRepository
    {
        private readonly CatalogDBContext context;
        public CatalogProductRepository(CatalogDBContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<Product> Add(Product item)
        {
            context.Add(item);
            await context.SaveChangesAsync();
            return item;
            //throw new System.NotImplementedException();
        }
        public async Task Delete(int id)
        {
            try
            {
                Product entity = await context.Products.FindAsync(id);
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Item not found");
            }


            //throw new System.NotImplementedException();
        }
        public async Task Update(Product item)
        {
            context.Update(item).State = EntityState.Modified;

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await context.Products.Include(c => c.LookUp).Include(c => c.Images).ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProduct(int id)
        {
            return await context.Products.Include("LookUp").Include("Image").ToListAsync();
        }
    }
}
