using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Item
    {
        private string name;
        private int weight;
        private int goldVvalue;
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int GoldVvalue
        {
            get { return goldVvalue; }
            set { goldVvalue = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
