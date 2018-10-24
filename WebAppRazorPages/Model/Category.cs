using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazorPages.Model
{
    public class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
