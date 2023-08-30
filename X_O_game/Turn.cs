using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class Turn
    {
        /// <summary>
        /// method to switch players turn
        /// </summary>
        /// <param name="playerTurn"></param>
        /// <returns></returns>
        public static int playerTurn(int playerTurn)
        {
            if (playerTurn == 1)
            {
                playerTurn = 2;
            }
            else
            {
                playerTurn = 1;
            }

            return playerTurn;
        }
        
    }
}
