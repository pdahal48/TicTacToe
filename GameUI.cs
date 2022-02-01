using System;
namespace TicTacToe
{
    public class GameUI
    {
       
        public void LoadUI(char[,] board)
        {
            Console.Clear();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j != 2)
                    {
                        Console.Write(" " + board[i, j] + " " + "|");
                    }
                    else
                    {
                        Console.Write(" " + board[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                if (i != 2)
                {
                    Console.WriteLine("___ ___ ___");
                }
                Console.WriteLine("");
            }
        }

    }


}
