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
        private bool playing = true;
        private bool newGame = true;
        private List<Room> roomList = new List<Room>() {
            new Room()
            {
                Gold = 0,
                Description = "You are in a cavernous room with a tiny fire in the middle. The goblin lies dead nearby.",
                ApproachDescription = "A dark room with a tiny light",
                Monster = new Enemy() {
                    Name = "goblin",
                    Description = "a fearsome goblin with a crooked sword",
                    Damage = 5,
                    Health = 2,
                    Gold = 10,
                    Loot = new Sword()
                    {
                        Name = "Sword",
                        Description = "a tiny sword",
                        Damage = 3
                    }
                },
                Loot = new Potion()
                {
                    Description = "Healing potion",
                    Name = "Potion",
                    Healing = 5
                },
                North = new Room()
                {
                    Description = "You are in a dark crypt with no light",
                    ApproachDescription = "a dark crypt down some windy stairs"
                }
            },

            new Room()
            {
                Gold = 5,
                Description = "room1",
                ApproachDescription = "room1",
                Loot = new Shield()
                {
                    Description = "a tiny shield",
                    Name = "Shield",
                    Block = 3
                }
            },
            new Room()
            {
                Gold = 5,
                Description = "room2",
                ApproachDescription = "room2",
                Loot = new Potion()
                {
                    Description = "Healing potion",
                    Name = "Potion",
                    Healing = 5
                },
                Monster = new Enemy()
                {
                    Name = "Troll",
                    Description = "a massive troll with rotting teeth and a foul breath",
                    Damage = 5,
                    Health = 20
                }
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
                Description = "You come out of the dungeon into the magnificent sunshine!",
                ApproachDescription = "room5",
                EndRoom = true
            }
        };
        

        public bool NewGame
        {
            get { return newGame; }
            set { newGame = value; }
        }


        public bool Playing
        {
            get { return playing; }
            set { playing = value; }
        }


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
            //puts the item in the players inventory and removes it from the room
            player.PickupItem(player.CurrentRoom.Loot);
            Console.WriteLine($"\nYou picked up {player.CurrentRoom.Loot.Name}\n");
            player.CurrentRoom.Loot = null;
        }

        public void SeeItems()
        {
            // loops through the players items and displays them.
            if (player.Items != null)
            {
                Console.WriteLine();
                foreach (Item item in player.Items)
                {
                    Console.WriteLine($"{item.Name}\n");
                }
            }
        }

        public void GetDescription()
        //displays the description of the room and its contents
        {
            string output = player.CurrentRoom.Description;
            if (player.CurrentRoom.Monster == null)
            {
                
                if (player.CurrentRoom.Loot != null)
                {
                    output = output + $"\n\nYou found {player.CurrentRoom.Loot.Description}";
                }
                if (player.CurrentRoom.Gold > 0)
                {
                    output = output + $"\n\nYou found {player.CurrentRoom.Gold} gold";
                }
                List<Room> rooms = GetAdjacentRooms();
                foreach (Room room in rooms)
                {
                    output += $"\n\n{room.ApproachDescription} to the {room.RelativeDirection}";
                }
            } else
            {
                output = $"Before you is {player.CurrentRoom.Monster.Description}. It jumps forward and attacks you,\n dealing {player.CurrentRoom.Monster.Damage} damage.";
                if(player.Block > 0)
                {
                    output += $"You blocked {player.Block} damage.";
                }
            }

            Console.WriteLine(output + "\n");
        }

        public void Combat()
        {
            player.HealthPoints -= (player.CurrentRoom.Monster.Damage - player.Block);
            if(player.HealthPoints <= 0)
            {                
                Console.WriteLine("\nYou died from the attack...");
                Console.ReadKey();
                playing = false;
            } else
            {
                Console.WriteLine("\nChoose an action");
                bool awaitingMove = true;
                while(awaitingMove)
                {
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "attack":
                            if (player.CurrentRoom.Monster != null)
                            {
                                
                                Console.WriteLine($"You deal {player.Damage} damage to the {player.CurrentRoom.Monster.Name}.\n");
                                player.CurrentRoom.Monster.Health -= player.Damage;
                                if (player.CurrentRoom.Monster.Health <= 0)
                                {
                                    
                                    Console.WriteLine($"You defeated the {player.CurrentRoom.Monster.Name}\n");
                                    awaitingMove = false;
                                    
                                    if(player.CurrentRoom.Monster.Gold > 0)
                                    {
                                        Console.WriteLine($"You looted {player.CurrentRoom.Monster.Gold} gold from the {player.CurrentRoom.Monster.Name}\n");
                                        player.CurrentGold += player.CurrentRoom.Monster.Gold;
                                    }
                                    if(player.CurrentRoom.Monster.Loot != null)
                                    {
                                        Console.WriteLine($"You looted a {player.CurrentRoom.Monster.Loot.Name} from the {player.CurrentRoom.Monster.Name}\n");
                                        player.PickupItem(player.CurrentRoom.Monster.Loot);
                                    }
                                    player.CurrentRoom.Monster = null;
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    
                                    player.HealthPoints -= (player.CurrentRoom.Monster.Damage - player.Block);
                                    if (player.HealthPoints <= 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"The {player.CurrentRoom.Monster.Name} lashes out at you and deal {player.CurrentRoom.Monster.Damage} damage");
                                        Console.WriteLine($"You died...\n");
                                        Console.ReadKey();
                                        awaitingMove = false;
                                        playing = false;
                                    } else
                                    {
                                        Console.WriteLine($"The {player.CurrentRoom.Monster.Name} lashes out at you and deal {player.CurrentRoom.Monster.Damage} damage");
                                        if (player.Block > 0)
                                        {
                                            Console.WriteLine($"You blocked {player.Block} damage."); 
                                        }
                                    }
                                }
                            }
                            break;
                        case "flee":
                            switch (player.CurrentRoom.RelativeDirection)
                            {
                                case "South":
                                    player.CurrentRoom = player.CurrentRoom.North;
                                    awaitingMove = false;
                                    break;
                                case "North":
                                    player.CurrentRoom = player.CurrentRoom.South;
                                    awaitingMove = false;
                                    break;
                                case "East":
                                    player.CurrentRoom = player.CurrentRoom.West;
                                    awaitingMove = false;
                                    break;
                                case "West":
                                    player.CurrentRoom = player.CurrentRoom.East;
                                    awaitingMove = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "help":
                            Console.WriteLine("\nType 'attack' to attack the enemy\n<<Type 'flee' to flee from the enemy\n");
                            break;
                        default:
                            Console.WriteLine("\ntype help for instructions\n");
                            break;
                    }
                }
            }
        }

        private List<Room> GetAdjacentRooms()
        {
            //returns a list cotaining the rooms adjacent to the current roomm,
            //and sets the relative direction of each adjacent room, so they return the correct approach description
            List<Room> choices = new List<Room>();
            if (player.CurrentRoom.North != null)
            {
                player.CurrentRoom.North.RelativeDirection = "North";
                choices.Add(player.CurrentRoom.North);
            }

            if (player.CurrentRoom.South != null)
            {
                player.CurrentRoom.South.RelativeDirection = "South";
                choices.Add(player.CurrentRoom.South);
            }

            if (player.CurrentRoom.East != null)
            {
                player.CurrentRoom.East.RelativeDirection = "East";
                choices.Add(player.CurrentRoom.East);
            }

            if (player.CurrentRoom.West != null)
            {
                player.CurrentRoom.West.RelativeDirection = "West";
                choices.Add(player.CurrentRoom.West);
            }


            return choices;
        }

        public void MakeChoices()
        {

            Console.WriteLine("Choose an action\n");
            bool awaitingMove = true;
            while (awaitingMove)
            {
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cheat":
                        player.CurrentRoom = roomList[5];
                        awaitingMove = false;
                        break;
                    case "go west":
                        if (player.CurrentRoom.West != null)
                        {
                            player.CurrentRoom = player.CurrentRoom.West;

                            awaitingMove = false;
                        }
                        else
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
                        Console.WriteLine($"\nYou have {player.CurrentGold} gold\n");
                        break;
                    case "health":
                        Console.WriteLine($"\nYou have {player.HealthPoints} health\n");
                        break;
                    case "help":
                        Console.WriteLine($"type 'go north' to go north, 'go east' to go east etc.\ntype 'health' to see your healthpoints\nType 'pickup' to pickup items\ntype 'gold' to see your gold\ntype'items' to see what is in your inventory \ntype 'quit' to exit the game\n");
                        break;
                    case "quit":
                        Console.Clear();
                        Console.WriteLine($"You sit down and wait to die...\n");
                        Console.ReadKey();
                        awaitingMove = false;
                        playing = false;
                        break;
                    case "pickup":
                        if(player.CurrentRoom.Loot != null)
                        {
                            PickupItem();
                        } else
                        {
                            Console.WriteLine("There is no item to pick up");
                        }
                        break;
                    case "items":
                        SeeItems();
                        break;
                    case "use potion":
                        Item potion = null;
                        foreach (Item item in player.Items)
                        {
                            if (item is Potion)
                            {
                                Potion p = (Potion)item;
                                
                                player.HealthPoints += p.Healing;

                                Console.WriteLine($"\nYou drink a potion and gain {p.Healing} health!\n");

                                potion = item;
                                break;
                            }
                        }
                        if (potion != null)
                        {
                            player.Items.Remove(potion);
                        }
                        else
                        {
                            Console.WriteLine("\nYou don't have a potion\n");
                        }
                        break;
                    default:
                        Console.WriteLine("\ntype help for instructions\n");
                        break;
                }
            }
        }
        public void EndGame()
        {
            Console.WriteLine($"You found the exit! You got away with {player.CurrentGold} gold!");
            List<string> scores = Highscore.SaveScore(player.CurrentGold, player.Name);
            Console.WriteLine("Highscores:\n");
            foreach (string s in scores)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }

       

        public void MakeMap()
        {
            //makes a map with a random layout
            Room[,] roomMap = new Room[5, 5];


            Random rnd = new Random();


            int xpos = 0;

            int ypos = 3;

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
            RoomList[0].North.South = roomList[0];
            player.CurrentRoom = RoomList[0].North;
        }
    }
}
