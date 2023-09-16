using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace EmmaWebsite.Pages_Friends
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesFriendContext _context;

        public DetailsModel(RazorPagesMovie.Data.RazorPagesFriendContext context)
        {
            _context = context;
        }

      public Friend Friend { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Friend == null)
            {
                return NotFound();
            }

            var friend = await _context.Friend.FirstOrDefaultAsync(m => m.Id == id);
            if (friend == null)
            {
                return NotFound();
            }
            else 
            {
                Friend = friend;
            }
            return Page();
        }
    }
}
