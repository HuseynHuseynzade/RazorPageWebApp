using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazorPages.Model
{
    public class User:IdentityUser
    {
        public User()
        {
            Articles = new HashSet<Article>();
        }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
