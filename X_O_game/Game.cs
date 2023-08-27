using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class Game
    {
        
        public static void changeBoardList(int field, List<string> elementNumber, int player)
        {
            if (player == 1)
            {
                elementNumber[field] = "x";
            }
            else
            {
                elementNumber[field] = "y";
            }
            foreach (string element in elementNumber)
            {
                Console.Write(" " + element + " ");
                if (elementNumber[2] == element || elementNumber[5] == element)
                {
                    Console.WriteLine();
                }


            }

        }
        public static int playerTurn( int playerTurn)
        {
                       
            if (playerTurn == 1)
            {
                playerTurn = 1;
            }
            else
            {
                playerTurn = 2;
            }

            return playerTurn;
        }
    }
}
