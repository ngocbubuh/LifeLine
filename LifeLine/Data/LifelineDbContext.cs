using LifeLine.Models;
using Microsoft.EntityFrameworkCore;

namespace LifeLine.Data
{
    public class LifelineDbContext : DbContext
    {
        public LifelineDbContext(DbContextOptions<LifelineDbContext> options) : base(options)
        {
            
        }
        public DbSet<FirstAidItem> FirstAidItems { get; set; }

        public DbSet<FirstAidItemDetail> FirstAidItemsDetail { get; set; }

        public DbSet<Dropdown> Dropdown { get; set; }
    }
}
