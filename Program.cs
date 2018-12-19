using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Moria";
            Console.SetWindowSize(101, 45);
            Console.WriteLine(@"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMhyNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNyhMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMd.//smMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNs//-dMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMd.  .//sNMMMMMMMMMMMMMMMMMMMMMMMMMMMMNs//.  .dMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMs`     .//sNMMMMMMMMMMMMMMMMMMMMMMMMNs//.     `yMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMddNMMMMMMMMd:         .//dMMMMMMMMMMMMMMMMMMMMMMd//.         :dMMMMMMMMNddMMMMMMMMMMMMM
MMMMMMMMMMMMMMs/smmMMMMN/:`         `:/sNMMMMMMMMMMMMMMMMMMNo/:`         `:/NMMMMmmo:sMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMd/-:+d+o- .+:`         .++NMMMMMMMMMMMMMMMMN++.         `:+. -o+d+:-/dMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMh/: ``:.   -+:` `-+o+/--+/mMMMMMMMMMMMMMMm/+--/+o+-` `:+-   -:`` :/hMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM+.`   .:. oNMh/hMMMMMMmhh/NMMMMMMMMMMMMN/hhmMMMMMMh/hMNo .:.   `.+MMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMmNh``:-`   .`hMMMMMMMMMMMMMMNNMMMMMMMMMMMMNNMMMMMMMMMMMMMMh`.   `-:``hNmMMMMMMMMMMMMMM
MMMMMMMMMMMMd/.+:`  `:-   `hmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmh`   -:`  `:+./dMMMMMMMMMMMM
MMMMMMMMNmy:`   -+: .++ooo`..+NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN+..`ooo++. :+.   `:ymNMMMMMMMM
MMMMMdho-`        -:mMMMMMs..s.sMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMs.s..sMMMMMm:-        `-ohdMMMMM
MMMMMNo/:`          -hMMMMMMo:``/oNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNo/``:sMMMMMMh-          `:/oNMMMMM
MMMMMMMd+/:`       `yMMMMMMMMMd` `/mMMMMMMMMMMMMMMMMMMMMMMMMMMMMm/` `dMMMMMMMMMy`       `:/+dMMMMMMM
MMMMMMMMMh+/:`     sMMMMMMMMMMMNy+``+mMMMMMMMMMMMMMMMMMMMMMMMMm+``+yNMMMMMMMMMMMs     `:/+hMMMMMMMMM
MMMMMMMMMMMd+//`   sMMMMMMMMMMMMMMm/ `+NMMMMMMMMMMMMMMMMMMMMN+` /mMMMMMMMMMMMMMMo   `//+dMMMMMMMMMMM
MMMMMMMMMMMMMms+/:``mMMMMMMMMMMMMMMMd/ `oNMMMMMMMMMMMMMMMMNo` /dMMMMMMMMMMMMMMMm``:/+sNMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMdo+:oNMMMMMMMMMMMMMMMMm/ `oNMMMMMMMMMMMMNo` :dMMMMMMMMMMMMMMMMm+:+odMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMmhyNMMMMMMMMMMMMMMMMMd:``oNMMMMMMMMNs.`/dMMMMMMMMMMMMMMMMMmohNMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd:`.sNMMMMNs../dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                      MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM Press Enter to Start MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                      MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM ▄▄       ▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░░▌     ▐░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌░▌   ▐░▐░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌▐░▌ ▐░▌▐░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌       ▐░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌ ▐░▐░▌ ▐░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░▌     ▐░█▄▄▄▄▄▄▄█░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌  ▐░▌  ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌     ▐░▌     ▐░░░░░░░░░░░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌   ▀   ▐░▌▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀      ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌       ▐░▌▐░▌       ▐░▌▐░▌     ▐░▌       ▐░▌     ▐░▌       ▐░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌  ▄▄▄▄█░█▄▄▄▄ ▐░▌       ▐░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀ MMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM   
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM   
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM   
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM   
");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {

            }
            Room room3 = new Room()
            {
                Description = "You found the exit!",
                ApproachDescription = "You can see something that looks like daylight"
            };
            Room room2 = new Room()
            {
                Gold = 5,
                Description = "You find yourself in a dark cavern with a fire in the middle",
                ApproachDescription = "You see light in the darkness",
                East = room3
            };
            room3.West = room2;
            Room room1 = new Room()
            {
                Gold = 0,
                Description = "You are in dank corridor",
                ApproachDescription = "You see an opening to a passage",
                North = room2
            };
            room2.South = room1;
            Game game = new Game
            {
                Player = new Player()
                {
                    Name = "Asger",
                    CurrentGold = 0,
                    CurrentRoom = room1
                }
            };
            Console.Clear();
            while (true)
            {
                

                Console.WriteLine(game.Player.CurrentRoom.GetDescription() + "\n");

                game.GetGold();

                game.GetChoices();

                Console.Clear();
            }


        }
    }
}
