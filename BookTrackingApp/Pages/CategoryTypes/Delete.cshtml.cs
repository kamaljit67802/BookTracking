using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookTrackingApp.Pages.CategoryTypes
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CategoryTypes == null)
            {
                return NotFound();
            }
            var categorytype = await _context.CategoryTypes.FindAsync(id);

            if (categorytype != null)
            {
                CategoryType = categorytype;
                _context.CategoryTypes.Remove(CategoryType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
