using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class Board
    {
        public static void drawBoard()
        {
            string[,] board = new string [3,3];
            int fieldNumber = 1;
            for (int i = 0;  i < board.GetLength(0); i++)
            {
                
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    
                    board[i, j] = fieldNumber.ToString();
                    fieldNumber++;
                    Console.Write("  " + board[i, j] + "  ");
                }
                Console.WriteLine();
            }
            
        }          
       

    }
}
