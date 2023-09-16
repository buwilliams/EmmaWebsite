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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesFriendContext _context;

        public IndexModel(RazorPagesMovie.Data.RazorPagesFriendContext context)
        {
            _context = context;
        }

        public IList<Friend> Friend { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Friend != null)
            {
                Friend = await _context.Friend.ToListAsync();
            }
        }
    }
}
