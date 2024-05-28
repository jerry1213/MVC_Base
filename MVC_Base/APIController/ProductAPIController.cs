using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Base.Models;
using MVC_Base.ViewModel;

namespace MVC_Base.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : Controller
    {
        private readonly NorthwindContext _context;

        public ProductAPIController(NorthwindContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
           var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        //// POST: api/products
        //[HttpPost]
        //public async Task<ActionResult<Products>> CreateProduct([FromBody] Products product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Products.Add(product);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetProduct), new { id = product.ProductID }, product);
        //}
        [HttpPost]
        public async Task<ActionResult<ReqCreateProductViewModel>> CreateProduct([FromBody] ReqCreateProductViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // 找到對應的供應商和類別
            var supplier = await _context.Suppliers.FirstOrDefaultAsync(s => s.CompanyName == viewModel.Supplier);
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryName == viewModel.Category);

            if (supplier == null || category == null)
            {
                return BadRequest("Supplier or Category not found.");
            }

            // 創建產品模型
            var product = new Products
            {
                ProductName = viewModel.ProductName,
                SupplierID = supplier.SupplierID,
                CategoryID = category.CategoryID,
                QuantityPerUnit = viewModel.QuantityPerUnit,
                Discontinued = viewModel.Discontinued
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Products product)
        {
            if (id != product.ProductID)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
