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
        private List<Room> roomList = new List<Room>() {
            new Room()
            {
                Gold = 0,
                Description = "Start room",
                ApproachDescription = "Start room"
            }
                 ,
            new Room()
            {
                Gold = 5,
                Description = "room1",
                ApproachDescription = "room1"
            },
            new Room()
            {
                Gold = 5,
                Description = "room2",
                ApproachDescription = "room2"
            },
            new Room()
            {
                Gold = 5,
                Description = "room3",
                ApproachDescription = "room3"
            },
            new Room()
            {
                Gold = 5,
                Description = "room4",
                ApproachDescription = "room4"
            },
            new Room()
            {
                Description = "room5",
                ApproachDescription = "room5"
            }
        };

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

        public void PickupItem()
        {
            player.Items.Add(player.CurrentRoom.Item);
            Console.WriteLine($"\nYou picked up {player.CurrentRoom.Item.Name}\n");
            player.CurrentRoom.Item = null;
        }

        public void SeeItems()
        {
            if(player.Items != null)
            {
                Console.WriteLine();
                foreach (Item item in player.Items)
                {
                    Console.WriteLine($"{item.Name}\n");
                }
            }
        }

        public void GetChoices()
        {
            List<Room> rooms = Player.CurrentRoom.GetChoices();
            
            


            Console.WriteLine("Choose an action\n");
            bool awaitingMove = true;
            while(awaitingMove)
            {
               string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "go west": 
                        if(player.CurrentRoom.West != null)
                        {
                            player.CurrentRoom = player.CurrentRoom.West;

                            awaitingMove = false;
                        } else
                        {
                            Console.WriteLine("You can't go west\n");
                        }
                        break;
                    case "go east":
                        if (player.CurrentRoom.East != null)
                        {
                            player.CurrentRoom = player.CurrentRoom.East;

                            awaitingMove = false;
                        }
                        else
                        {
                            Console.WriteLine("You can't go east\n");
                        }
                        break;
                    case "go north":
                        if (player.CurrentRoom.North != null)
                        {
                            player.CurrentRoom = player.CurrentRoom.North;

                            awaitingMove = false;
                        }
                        else
                        {
                            Console.WriteLine("You can't go north\n");
                        }
                        break;
                    case "go south":
                        if (player.CurrentRoom.South != null)
                        {
                            player.CurrentRoom = player.CurrentRoom.South;

                            awaitingMove = false;
                        }
                        else
                        {
                            Console.WriteLine("You can't go west\n");
                        }
                        break;
                    case "gold":
                        Console.WriteLine($"You have {player.CurrentGold} gold\n");
                        break;
                    case "pick up item":
                        PickupItem();
                        break;
                    case "see items":
                        SeeItems();
                        break;
                    default:
                        Console.WriteLine("\ntype help for instructions\n");
                        break;
                }
            }
        }

        public void MakeMap()
        {

            Room[,] roomMap = new Room[8, 8];

            

            Random rnd = new Random();

            int xpos = 0;

            int ypos = 2;

            int lastDir = 1;

            int rooms = 0;

            while (rooms < 6)
            {
                if (roomMap[xpos, ypos] == null)
                {

                    
                    roomMap[xpos, ypos] = roomList[rooms];
                    if (xpos - 1 >= 0)
                    {
                        if (roomMap[xpos - 1, ypos] != null)
                        {
                            roomList[rooms].North = roomMap[xpos - 1, ypos];
                            roomMap[xpos - 1, ypos].South = roomList[rooms];
                        }
                    }
                    if (xpos + 1 <= roomMap.GetUpperBound(0))
                    {
                        if (roomMap[xpos + 1, ypos] != null)
                        {
                            roomList[rooms].South = roomMap[xpos + 1, ypos];
                            roomMap[xpos + 1, ypos].North = roomList[rooms];
                        }
                    }
                    if (ypos + 1 <= roomMap.GetUpperBound(1))
                    {
                        if (roomMap[xpos, ypos + 1] != null)
                        {
                            roomList[rooms].East = roomMap[xpos, ypos + 1];
                            roomMap[xpos, ypos + 1].West = roomList[rooms];
                        }
                    }
                    if (ypos - 1 >= 0)
                    {
                        if (roomMap[xpos, ypos - 1] != null)
                        {
                            roomList[rooms].West = roomMap[xpos, ypos - 1];
                            roomMap[xpos, ypos - 1].East = roomList[rooms];
                        }
                    }
                    rooms++;
                }
               

                int dir = rnd.Next(4);

                for (int i = 0; i < 2; i++)
                {
                    if (dir != lastDir)
                    {
                        dir = rnd.Next(4);
                    }
                }
                switch (dir)
                {
                    case 0:
                        if (xpos - 1 >= 0)
                        {
                            xpos--;
                            lastDir = 0;
                        }
                        break;
                    case 1:
                        if (xpos + 1 <= roomMap.GetUpperBound(0))
                        {
                            xpos++;
                            lastDir = 1;
                        }
                        break;
                    case 2:
                        if (ypos + 1 <= roomMap.GetUpperBound(1))
                        {
                            ypos++;
                            lastDir = 2;
                        }
                        break;
                    case 3:
                        if (ypos - 1 >= 0)
                        {
                            ypos--;
                            lastDir = 3;
                        }
                        break;
                    default:
                        break;
                }


            }

            player.CurrentRoom = RoomList[0];
        }
    }
}
