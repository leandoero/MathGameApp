using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameApp.Logic.History
{
    public class Match
    {
        public DateTime MatchStart { get; set; }
        public DateTime MatchEnd { get; set; }
        public int Result { get; set; }
        public string GameMode { get; set; }
        public Match(string gameMode)
        {
            MatchStart = DateTime.Now;
            GameMode = gameMode;
        }
        public override string ToString()
        {
            return $"StartTime:{MatchStart}, EndTime:{MatchEnd}, Result:{Result}, GameMode:{GameMode}";
        }
    }
}
