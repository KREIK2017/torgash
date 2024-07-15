using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using torgash.Model.Cards;

namespace torgash.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CardDB _context;
        public IndexModel(ILogger<IndexModel> logger, CardDB context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<Card> Cards { get; set; }

        public async Task OnGetAsync()
        {
            Cards = await _context.Cards.ToListAsync();
        }

    }
}