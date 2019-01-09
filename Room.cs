using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Room
    {
        private Room north;
        private Room south;
        private Room east;
        private Room west;
        private string relativeDirection;       
        private string approachDescription;
        private int gold;
        private string description;
        private Item loot;
        private bool endRoom;
        private Enemy monster;

        public Enemy Monster
        {
            get { return monster; }
            set { monster = value; }
        }


        public bool EndRoom
        {
            get { return endRoom; }
            set { endRoom = value; }
        }


        public Item Loot
        {
            get { return loot; }
            set { loot = value; }
        }


        public string ApproachDescription
        {
            get { return approachDescription; }
            set { approachDescription = value; }
        }

        

        public string RelativeDirection
        {
            get { return relativeDirection; }
            set { relativeDirection = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }


        public Room West
        {
            get { return west; }
            set { west = value; }
        }


        public Room East
        {
            get { return east; }
            set { east = value; }
        }


        public Room South
        {
            get { return south; }
            set { south = value; }
        }


        public Room North
        {
            get { return north; }
            set { north = value; }
        }
        
    }
}
