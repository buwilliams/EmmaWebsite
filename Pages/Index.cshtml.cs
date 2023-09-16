using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using System.Threading.Tasks;

namespace EmmaWebsite.Pages;

public class IndexModel : PageModel
{

    private readonly ILogger<IndexModel> _logger;
    private readonly RazorPagesMovie.Data.RazorPagesFriendContext _context;
    public IList<Friend> Friend { get;set; } = default!;

    public IndexModel(ILogger<IndexModel> logger, RazorPagesMovie.Data.RazorPagesFriendContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task OnGetAsync()
    {
        if (_context.Friend != null)
        {
            Friend = await _context.Friend
                .OrderByDescending(p => p.Likes)
                .ToListAsync();
        }
    }
}
