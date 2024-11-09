using Microsoft.AspNetCore.Mvc;
using BasicECommerce.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using BasicECommerce.Models;

namespace BasicECommerce.Controllers
{
    public class PagesController(DataContext context) : Controller
    {
        private readonly DataContext _context = context;

        public async  Task<IActionResult> Index(string slug = "")
        {
            slug = slug.IsNullOrEmpty() ? "home" : slug;

            Page page = await _context.Pages.Where(x => x.Slug == slug).FirstOrDefaultAsync();

            if (page == null)
            {
                return NotFound();
            }
            return View(page);
        }
    }
}
