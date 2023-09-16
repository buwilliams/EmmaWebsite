using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace EmmaWebsite.Pages_Friends
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesFriendContext _context;

        public CreateModel(RazorPagesMovie.Data.RazorPagesFriendContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Friend Friend { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Friend == null || Friend == null)
            {
                return Page();
            }

            _context.Friend.Add(Friend);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
