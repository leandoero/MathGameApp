using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGameApp.Logic.History;
using MathGameApp.Logic.Operations;
using MathGameApp.Logic.Score;

namespace MathGameApp.Logic.Games
{
    public class MixGame
    {
        public void Start(MatchHistory history)
        {
            Console.Clear();
            Console.WriteLine($"Game Mode: Mix");

            Random random = new Random();

            var score = new ScoreForGame();

            var match = new Match("Mix");

            while (true)
            {
                char[] chars = { '+', '-', '/', '*' };
                int index = random.Next(chars.Length);

                int numberFirst, numberSecond;
                if (chars[index] == '/')
                {
                    do
                    {
                        numberFirst = random.Next(1, 21);
                        numberSecond = random.Next(1, 11);
                    } while (numberFirst % numberSecond != 0);
                }
                else
                {
                    numberFirst = random.Next(1, 11);
                    numberSecond = random.Next(1, 11);
                }


                Console.Write($"{numberFirst} {chars[index]} {numberSecond} = ");
                IOperation op = OperationFactory.GetOperation(chars[index]);
                int answer = 0;
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (answer == op.Execute(numberFirst, numberSecond))
                    {
                        score.AddPoint();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine($"Scored points: {score.GetScore()}");

            match.MatchEnd = DateTime.Now;
            match.Result = score.GetScore();

            history.AddMatch(match);
            Console.WriteLine();
            while (true)
            {
                Console.Write("Start the game again? y/n : ");

                string? userChoice = Console.ReadLine();
                if (userChoice?.ToUpper() == "Y")
                {
                    Start(history);
                    break;
                }
                else if (userChoice?.ToUpper() == "N")
                {
                    break;
                }
            }
        }
    }
}
