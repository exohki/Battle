using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCTC_Battle.Models
{
    public class Leather : IArmor
    {
        public Leather()
        {
            Name = "Leather";
        }

        public string Name { get; set; }
        public int Defense { get; set; }
    }
}
