using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazorPages.Model
{
    public class SocialAccount
    {
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Gmail { get; set; }
    }
}
