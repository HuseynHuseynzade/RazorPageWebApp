using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazorPages.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
