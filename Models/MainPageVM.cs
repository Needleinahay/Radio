using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MainPageVM
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Country> Countries { get; set; }
    }
}
