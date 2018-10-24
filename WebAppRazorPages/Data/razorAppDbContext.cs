using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppRazorPages.Model;

namespace WebAppRazorPages.Data
{
    public class razorAppDbContext : DbContext
    {
        public razorAppDbContext(DbContextOptions<razorAppDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }
    }
}
  
