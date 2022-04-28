using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProductCatalog.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class UserService : IUserService
    {
        private readonly string catalogServiceUrl;
        public UserService(IConfiguration config)
        {
            catalogServiceUrl = config["CatalogUrl"];
        }

        public async Task<IEnumerable<User>> GetUserItemsAsync()
        {
            var client = new HttpClient();
            var result = await client.GetAsync(catalogServiceUrl + "/api/User/");
            var dataString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<User>>(dataString);
        }


    }
}

