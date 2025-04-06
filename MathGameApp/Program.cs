using MathGameApp.Logic;
using MathGameApp.Logic.Operations;
using MathGameApp.Logic.Games;
using MathGameApp.Logic.History;


namespace ProgramNamespace;
class Program
{
    public static void Main(string[] args)
    {
        var matchHistory = new MatchHistory();
        bool flag = true;
        do {
            Console.Clear();
            Console.WriteLine("Select the mode:\n1) Multiplication (*)\n2) Division (/)\n3) Addition (+)\n4) Subtraction (-)\n5) Mix (*  /  +  -)\n6) Match history\n7) Exit");
            Console.WriteLine();
            Console.Write("Input: ");
            int numberChoice = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numberChoice))
                {
                    if (numberChoice <= 7 && numberChoice >= 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error! Write the number from the range from 1 to 7");
                        Console.Write("Input: ");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Enter The Number.");
                    Console.Write("Input: ");
                }
            }

            switch (numberChoice)
            {
                case 1:
                    var gameMultiplication = new MultiplicationGame();
                    gameMultiplication.Start('*', matchHistory);
                    break;
                case 2:
                    var gameDivision = new DivisionGame();
                    gameDivision.Start('/', matchHistory);
                    break;
                case 3:
                    var gameAddition = new AdditionGame();
                    gameAddition.Start('+', matchHistory);
                    break;
                case 4:
                    var gameSubtraction = new SubtractionGame();
                    gameSubtraction.Start('-', matchHistory);
                    break;
                case 5:
                    var gameMix = new MixGame();
                    gameMix.Start(matchHistory);
                    break;
                case 6:
                    matchHistory.ShowHistory();
                    Console.Write("Press any key to continue");
                    Console.ReadLine();
                    break;
                case 7:
                    flag = false;
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported number: {numberChoice}");
            }
        } while (flag);
        

    }
}