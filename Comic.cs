using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFLINQ
{
    class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }
        public override string ToString() => $"{Name} (Issue #{Issue})";
    }
}
