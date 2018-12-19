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
        

    }
}
