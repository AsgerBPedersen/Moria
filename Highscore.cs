using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Moria
{
    class Highscore
    {
        public static List<string> SaveScore(int score, string name)
        {
            List<string> scores = new List<string>();
            string line;
            using (StreamReader reader = new StreamReader(@"C:\Users\asge4899\source\repos\Moria\MoriaHighscores.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    scores.Add(line);
                }
            }
            scores.Add($"{score} - {name}");
            scores.Sort();
            scores.Reverse();
            using (StreamWriter writer = new StreamWriter(@"C:\Users\asge4899\source\repos\Moria\MoriaHighscores.txt", false))
            {
                foreach (string s in scores)
                {
                    writer.WriteLine(s);
                }
            }
            return scores;
        }
    }
}
