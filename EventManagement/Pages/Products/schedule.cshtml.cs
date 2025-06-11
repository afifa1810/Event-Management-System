using EventManagement.DAL;
using EventManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.Pages.Products
{
    public class scheduleModel : PageModel
    {
        private readonly MyAppDbContext _context;

        public scheduleModel(MyAppDbContext context)
        {
            _context = context;
        }
        public List<Product> Products { get; set; }
        public async Task OnGetAsync() 
        {
            if(_context.Products != null)
            {
                Products = await _context.Products.ToListAsync();
            }
        }
    }
}
