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
        private Item item = new Sword() {
            Description = "a tiny sword",
            Name = "Bobs Sword"
        };

        public Item Item
        {
            get { return item; }
            set { item = value; }
        }


        public string ApproachDescription
        {
            get { return approachDescription; }
            set { approachDescription = value; }
        }

        private int gold;
        private string description;

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
        public string GetDescription()
        {
            string output = Description;
            if(Item != null)
            {
                output = output + $"\n\n You found {Item.Description}";
            }
            if(Gold > 0)
            {
                output = output + $"\n\n You found {Gold} gold";
            }
            List < Room > rooms = GetChoices();
            foreach (Room room in rooms)
            {
                output += $"\n\n {room.ApproachDescription} to the {room.RelativeDirection}";
            }
            return output;
        }
        public List<Room> GetChoices()
        {
            List<Room> choices = new List<Room>();
            if(North != null)
            {
                North.RelativeDirection = "North";
                choices.Add(North);
            }

            if(South != null)
            {
                South.RelativeDirection = "South";
                choices.Add(South);
            }

            if(East != null)
            {
                East.RelativeDirection = "East";
                choices.Add(East);
            }

            if (West != null)
            {
                West.RelativeDirection = "West";
                choices.Add(West);
            }
            return choices;
        }

    }
}
