using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Player
    {
        private string name;
        private Room currentRoom;
        private int currentGold;
        private int healthPoints;
        private List<Item> items = new List<Item>();
        private int damage = 2;
        private int block;

        public int Block
        {
            get { return block; }
            set { block = value; }
        }


        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }


        public int HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }
        }

        public int CurrentGold
        {
            get { return currentGold; }
            set { currentGold = value; }
        }

        public Room CurrentRoom
        {
            get { return currentRoom; }
            set { currentRoom = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void PickupItem(Item item)
        {
            if(item is Sword s)
            {
                damage += s.Damage;
                items.Add(item);
            } else if (item is Potion)
            {
                items.Add(item);
            } else if (item is Shield sh)
            {
                block += sh.Block;
                items.Add(item);
            }
        }

    }
}
