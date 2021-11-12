using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SR1POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SR1POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{code}")]
        public async Task<IActionResult> GetProduct(string code)
        {
            var data = await (from p in _context.Product
                        join pp in _context.ProductPrice on p.UnitId equals pp.UnitId
                        where p.Barcode.Equals(code)
                        select new
                        {
                            p.ProductId,
                            p.ProductName,
                            p.UnitId,
                            p.Cost,
                            pp.Price,
                            p.OnHand
                        }).FirstOrDefaultAsync();
            return Ok(data);
        }
    }
}
