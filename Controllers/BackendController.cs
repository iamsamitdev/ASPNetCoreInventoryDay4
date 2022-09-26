using ASPNetCoreInventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInventory.Controllers
{
   [SessionCheck]
    public class BackendController : Controller
    {

        private readonly InventoryDBContext _context;

        // Constructure
        public BackendController(InventoryDBContext context)
        {
            _context = context;
        }

        // GET: Backend/Products
        public async Task<IActionResult> Products()
        {
            return View("~/Views/Products/Index.cshtml", await _context.products.ToListAsync());
        }

        // GET: Backend/Products/Details/5
        [Route("Backend/Products/Details/{id?}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/Products/Details.cshtml", product);
        }


        // GET: Backend/Products/Create
        [Route("Backend/Products/Create")]
        public IActionResult Create()
        {
            return View("~/Views/Products/Create.cshtml");
        }


        // POST: Backend/Products/Create
        [HttpPost]
        [Route("Backend/Products/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,CategoryID,ProductName,UnitPrice,ProductPicture,UnitInStock,CreatedDate,ModifiedDate")] product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Products", "Backend");
            }
            return View(product);
        }


        // GET: Backend/Products/Edit/5
        [Route("Backend/Products/Edit/{id?}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View("~/Views/Products/Edit.cshtml", product);
        }


        // POST: Backend/Products/Edit/5
        [HttpPost]
        [Route("Backend/Products/Edit/{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,CategoryID,ProductName,UnitPrice,ProductPicture,UnitInStock,CreatedDate,ModifiedDate")] product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!productExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Products", "Backend");
            }
            return View(product);
        }

        private bool productExists(int id)
        {
            return _context.products.Any(e => e.ProductID == id);
        }


        // GET: Backend/Products/Delete/5
        [Route("Backend/Products/Delete/{id?}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/Products/Delete.cshtml", product);
        }


        // POST: Backend/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("Backend/Products/Delete/{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.products.FindAsync(id);
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Products", "Backend");
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Logout()
        {
            // Remove Session ทั้งหมด
            HttpContext.Session.Clear();

            return RedirectToAction("Login", "Frontend");
        }
    }
}
