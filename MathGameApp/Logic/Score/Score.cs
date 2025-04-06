using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameApp.Logic.Score
{
    public class ScoreForGame
    {
        private int _value;

        public ScoreForGame() { 
            _value = 0;
        }
        public void AddPoint() => _value++;
        public void Reset() => _value = 0;
        public int GetScore() => _value;

    }
}
