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
            Console.Clear();
            bool newGame = true;
            while (newGame)
            {
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Game game = new Game()
                {
                    Player = new Player()
                    {
                        Name = name,
                        CurrentGold = 0,
                        HealthPoints = 10
                    }
                };
                game.MakeMap();
                
                Console.Clear();

                while (game.Playing)
                {

                    game.GetDescription();

                    game.GetGold();
                    if (game.Player.CurrentRoom.EndRoom == true)
                    {

                        game.Playing = false;
                        game.EndGame();
                    }
                    else if (game.Player.CurrentRoom.Monster != null)
                    {
                        game.Combat();
                        Console.Clear();
                    }
                    else
                    {
                        game.MakeChoices();
                        Console.Clear();
                    }

                }
                Console.WriteLine("Do you want to 'exit' the game or start a 'new game'?");
                bool awaitingChoice = true;
                while (awaitingChoice)
                {
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "exit":
                            awaitingChoice = false;
                            newGame = false;
                            break;
                        case "new game":
                            awaitingChoice = false;
                            break;
                        default:
                            Console.WriteLine("Type 'exit' to exit the game.\nType 'new game' to start a new game");
                            break;
                    }
                }
                Console.Clear();
            }
        }
    }
}
