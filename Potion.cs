using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Potion : Item
    {
        private int healing;

        public int Healing
        {
            get { return healing; }
            set { healing = value; }
        }
        
    }
}
