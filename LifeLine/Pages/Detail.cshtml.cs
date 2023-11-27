using LifeLine.Data;
using LifeLine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LifeLine.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly LifelineDbContext _context;
        public IEnumerable<FirstAidItemDetail> FirstAidItemDetail { get; set; }
        public IEnumerable<Dropdown> Dropdown { get; set; }
        public IEnumerable<FirstAidItem> FirstAid { get; set; } //Cái này dùng làm mục lục các bài viết
        public PrivacyModel(LifelineDbContext dbContext)
        {
            _context = dbContext;
        }

        public void OnGet(int detailId)
        {
            FirstAidItemDetail = _context.FirstAidItemsDetail.Where(x=> x.Id == detailId);
            Dropdown = _context.Dropdown.Where(x => x.FirstAidDetailId == detailId);
            FirstAid = _context.FirstAidItems;
        }
    }
}