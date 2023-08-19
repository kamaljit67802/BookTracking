using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookTrackingApp.Pages.CategoryTypes
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

      public CategoryType CategoryType { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CategoryTypes == null)
            {
                return NotFound();
            }

            var categorytype = await _context.CategoryTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (categorytype == null)
            {
                return NotFound();
            }
            else 
            {
                CategoryType = categorytype;
            }
            return Page();
        }
    }
}
