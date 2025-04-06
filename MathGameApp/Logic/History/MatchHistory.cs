using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MathGameApp.Logic.History
{
    public class MatchHistory
    {
        private List<Match> matches;
        public MatchHistory() {
            matches = new List<Match>();
        }

        public void AddMatch(Match match)
        {
            matches.Add(match);
        }

        public void ShowHistory()
        {
            Console.Clear();
            Console.WriteLine("Matches:\n");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.ToString());
                Console.WriteLine();
            }
        }
    }
}
