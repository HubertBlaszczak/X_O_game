using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class Board
    {
        public static void drawBoardArray()
        {
            string[,] board = new string[3, 3];
            int fieldNumber = 1;
            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {

                    board[i, j] = fieldNumber.ToString();
                    fieldNumber++;
                    Console.Write(" " + board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
            public static void drawBoardList()
            {
                List<string> elementNumber = new List<string>() { "1","2","3","4","5","6","7","8","9" };
                
            foreach (string element in elementNumber)
            {                               
                Console.Write(" " + element + " ");
                if (elementNumber[2] == element || elementNumber[5] == element)
                {
                    Console.WriteLine();
                }
                
                
            }

           
            
        }
            //public static string changeField(string fieldNumber)
        //{

        //}
       
       

    }
}
