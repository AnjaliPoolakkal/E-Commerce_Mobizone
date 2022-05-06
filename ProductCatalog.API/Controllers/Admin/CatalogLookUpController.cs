using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessObject;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ProductCatalog.API.Controllers
{
    [Authorize(Roles ="admin")]
    [Route("[controller]")]
    [ApiController]
    public class CatalogLookUpController : ControllerBase
    {
        

        private readonly ICatalogLookUpBO catalogLookUpBO;

        public CatalogLookUpController(ICatalogLookUpBO catalogLookUpBO)
        {
            this.catalogLookUpBO = catalogLookUpBO;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LookUp>>> GetLookUpItems()
        {
            return Ok(await catalogLookUpBO.GetLookUpItems());

        }


        [HttpPost]
        public async Task<ActionResult<LookUp>> post(LookUp lookUp)
        {
                //lookUp.CreatedOnUTC = DateTime.UtcNow;
                var item = await catalogLookUpBO.Add(lookUp);
                
                if (item.name == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction("GetLookUpItems", new { id = lookUp.Id }, item);
                }
           
        }

       



    }
}
