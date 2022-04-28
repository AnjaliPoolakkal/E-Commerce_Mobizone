using ProductCatalog.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUserItemsAsync();
    }
}
