using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Game
    {
        private Player player;
        private List<Room> roomList;
        
        public List<Room> RoomList
        {
            get { return roomList; }
            set { roomList = value; }
        }
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }
        public void GetGold()
        {
            player.CurrentGold += player.CurrentRoom.Gold;
            player.CurrentRoom.Gold = 0;
        }

        public void GetChoices()
        {
            List<Room> rooms = Player.CurrentRoom.GetChoices();
            int i = 1;
            foreach (Room room in rooms)
            {
                Console.WriteLine($" {i}: Go {room.RelativeDirection}.");
                i++;
            }
            Console.WriteLine($" {i}: See your gold count.");

            Console.WriteLine("\nChoose an action");

            int ac = 0;

            while (!int.TryParse(Console.ReadLine(), out ac) || !(ac >= 1 && ac < i + 1))
            {
                Console.WriteLine("Invalid input");
            }

            while (ac > rooms.Count)
            {
                Console.WriteLine($"You have {player.CurrentGold} gold");
                while (!int.TryParse(Console.ReadLine(), out ac) || !(ac >= 1 && ac < i + 1))
                {
                    Console.WriteLine("Invalid input");
                }
            }
            Player.CurrentRoom = rooms[ac - 1];
        }

       
    }
}
