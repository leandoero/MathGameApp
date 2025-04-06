using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGameApp.Logic.History;

namespace MathGameApp.Logic.Games
{
    public class SubtractionGame
    {
        public void Start(char operation, MatchHistory history)
        {
            var game = new MathGame();
            game.PlayGame(operation, history);

        }
    }
}
