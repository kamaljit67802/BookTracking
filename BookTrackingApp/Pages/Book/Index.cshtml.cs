using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookTrackingApp.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<CategoryType> CategoryType { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CategoryTypes != null)
            {
                CategoryType = await _context.CategoryTypes.ToListAsync();
            }
        }
    }
}
