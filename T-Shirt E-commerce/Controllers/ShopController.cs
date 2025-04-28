using Microsoft.AspNetCore.Mvc;
using T_Shirt_E_commerce.Data; // important: import your Data namespace
using System.Linq;

namespace T_Shirt_E_commerce.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();  // get all products from DB
            return View(products);
        }
    }
}
