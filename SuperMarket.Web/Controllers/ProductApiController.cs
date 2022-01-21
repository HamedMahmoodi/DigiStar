using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.DataLayer.Context;

namespace SuperMarket.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private SuperMarketContext _context;
        public ProductApiController(SuperMarketContext context)
        {
            _context = context;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var productTitle = _context.Products.Where(p => p.ProductTitle.Contains(term))
                    .Select(p => p.ProductTitle).ToList();
                return Ok(productTitle);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
