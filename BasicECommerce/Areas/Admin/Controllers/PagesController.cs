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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Page page)
        {
            if (ModelState.IsValid)
            {
                page.Slug = page.Title.ToLower().Replace(" ", "-");

                var slug = await _context.Pages.FirstOrDefaultAsync(x => x.Slug == page.Slug);

                if (slug != null)
                {
                    ModelState.AddModelError("", "That page already exists!");
                    return View(page);
                }

                _context.Add(page);
                await _context.SaveChangesAsync();

                TempData["Success"] = "The page has been added!";

                return RedirectToAction("Index");
            }

            return View(page);
        }
    }
}
