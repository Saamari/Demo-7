using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tv_program
{   [Serializable]
    class Television
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Info { get; set; }
    }
}
