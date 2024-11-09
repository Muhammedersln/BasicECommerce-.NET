using Microsoft.AspNetCore.Mvc;
using BasicECommerce.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using BasicECommerce.Models;

namespace BasicECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController(DataContext context) : Controller
    {
        private readonly DataContext _context = context;

        public async  Task<IActionResult> Index()
        {
            List<Page> pages = await _context.Pages.ToListAsync();
            return View(pages);
        }

        public IActionResult Create ()
        {
            return View();
        }
    }
}
