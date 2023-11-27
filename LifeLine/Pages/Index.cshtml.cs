using LifeLine.Data;
using LifeLine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LifeLine.Pages
{
    public class IndexModel : PageModel
    {

        private readonly LifelineDbContext _context;
        public IEnumerable<FirstAidItem> FirstAid {  get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public IndexModel(LifelineDbContext dbContext)
        {
            _context = dbContext;
        }

        public void OnPost()
        {
            FirstAid = _context.FirstAidItems;
        }

        public async Task OnGetAsync(string searchString)
        {
            var items = from m in _context.FirstAidItems
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Name.Contains(searchString));
            }

            FirstAid = await items.ToListAsync();
        }
    }
}