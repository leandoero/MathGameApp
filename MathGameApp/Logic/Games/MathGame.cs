using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGameApp.Logic.Operations;
using MathGameApp.Logic.Score;
using MathGameApp.Logic.History;
using ProgramNamespace;
using static System.Formats.Asn1.AsnWriter;

namespace MathGameApp.Logic.Games
{
    public class MathGame
    {
        public void PlayGame(char operation, MatchHistory history)
        {
            Console.Clear();
            Console.WriteLine($"Game Mode:{operation}");

            IOperation op = OperationFactory.GetOperation(operation);

            Random random = new Random();

            var score = new ScoreForGame();

            string matchMode = operation.ToString();
            var match = new Match(matchMode);

            while (true)
            {
                int numberFirst, numberSecond;
                if (operation == '/')
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


                Console.Write($"{numberFirst} {operation} {numberSecond} = ");
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
                    PlayGame(operation, history);
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
