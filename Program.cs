using System;

namespace TicTacToe
{
    class Program
    {

        static char[,] board =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static char[,] initialBoard =
 {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static int player = 2;
        static int input = 0;
        static bool inputCorrect = true;
        static bool gameOver = IsOver();
        static GameUI gameUI = new GameUI();


        static void Main(string[] args)
        {

            do
            {
                if (player == 2)
                {
                    player = 1;
                    ConvertPlayerNums(player, input);
                } else if (player == 1)
                {
                    player = 2;
                    ConvertPlayerNums(player, input);
                }

                gameUI.LoadUI(board);
                IsOver();

                do
                {
                    Console.Write("\nPlayer {0}: choose your number: ", player);

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        ValidateInput(input);
                    }

                    catch
                    {
                        Console.WriteLine("Please Enter a Number ");
                        inputCorrect = false;
                    }

                } while (!inputCorrect && !gameOver);
            }

            while (!gameOver) ;
        }

        public static void ConvertPlayerNums(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1) playerSign = 'X';
            else if (player == 2) playerSign = 'O';

            switch (input)
            {
                case 1: board[0, 0] = playerSign; break;
                case 2: board[0, 1] = playerSign; break;
                case 3: board[0, 2] = playerSign; break;
                case 4: board[1, 0] = playerSign; break;
                case 5: board[1, 1] = playerSign; break;
                case 6: board[1, 2] = playerSign; break;
                case 7: board[2, 0] = playerSign; break;
                case 8: board[2, 1] = playerSign; break;
                case 9: board[2, 2] = playerSign; break;
            }
        }

        public static void ValidateInput(int userInput)
        {
            if ((userInput == 1) && board[0, 0] == '1')
            {
                inputCorrect = true;

            } else if ((userInput == 2) && board[0, 1] == '2')
            {
                inputCorrect = true;
            }
            else if ((userInput == 3) && board[0, 2] == '3')
            {
                inputCorrect = true;
            }
            else if ((userInput == 4) && board[1, 0] == '4')
            {
                inputCorrect = true;
            }
            else if ((userInput == 5) && board[1, 1] == '5')
            {
                inputCorrect = true;
            }
            else if ((userInput == 6) && board[1, 2] == '6')
            {
                inputCorrect = true;
            }
            else if ((userInput == 7) && board[2, 0] == '7')
            {
                inputCorrect = true;
            }
            else if ((userInput == 8) && board[2, 1] == '8')
            {
                inputCorrect = true;
            }
            else if ((userInput == 9) && board[2, 2] == '9')
            {
                inputCorrect = true;
            }
            else
            {
                Console.WriteLine("Number has already been chosen! choose another");
                inputCorrect = false;
            }
        }

        public static bool IsOver()
        {
            char[] charPlayers = { 'X', 'O' };

            foreach (var charplayer in charPlayers)
            {
                if (((board[0, 0] == charplayer) && (board[0, 1] == charplayer) && (board[0, 2] == charplayer))
                    || ((board[1, 0] == charplayer) && (board[1, 1] == charplayer) && (board[1, 2] == charplayer))
                    || ((board[2, 0] == charplayer) && (board[2, 1] == charplayer) && (board[2, 2] == charplayer))
                    || ((board[0, 0] == charplayer) && (board[1, 0] == charplayer) && (board[2, 0] == charplayer))
                    || ((board[0, 1] == charplayer) && (board[1, 1] == charplayer) && (board[1, 2] == charplayer))
                    || ((board[0, 2] == charplayer) && (board[2, 1] == charplayer) && (board[2, 2] == charplayer))
                    || ((board[0, 0] == charplayer) && (board[1, 1] == charplayer) && (board[2, 2] == charplayer))
                    || ((board[0, 2] == charplayer) && (board[1, 1] == charplayer) && (board[2, 0] == charplayer)) )
                {
                    if (charplayer == 'X')
                    {
                        //Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Congrats Chyas");
                        

                    } else if (charplayer == 'O')
                    {
                        //Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Congrats Chyas!!");
                        
                    }

                    Console.WriteLine("Game over. Press any key to reset");
                    Console.ReadKey();
                    Reset();

                    break;
                }
            }

            return false;
        }

        public static void Reset()
        {
            board = initialBoard;
            gameUI.LoadUI(board);
            player = 1;
        }
    }
}
