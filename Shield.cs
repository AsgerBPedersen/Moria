using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Shield : Item
    {
        private int block;

        public int Block
        {
            get { return block; }
            set { block = value; }
        }

    }
}
