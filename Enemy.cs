using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Enemy
    {
        private string name;
        private string description;
        private int health;
        private int damage;
        private Item loot;
        private int gold;

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }


        public Item Loot
        {
            get { return loot; }
            set { loot = value; }
        }


        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
