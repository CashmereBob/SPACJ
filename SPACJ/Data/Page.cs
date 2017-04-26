using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Page
    {
        public int Id { get; set; }
        public string HeaderImage { get; set; }
        public string TitleImage { get; set; }
        public string Header { get; set; }
        public string HeaderContent { get; set; }
        public string Title { get; set; }
        public string TitleContent { get; set; }
        public ICollection<Link> Links { get; set; }
        public Page()
        {
            Links = new HashSet<Link>();
        }
    }
}
