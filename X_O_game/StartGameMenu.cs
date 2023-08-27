using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class StartGameMenu
    {
        public static int whoStart()
        {
            Random random = new Random();

            
            int playerTurn = random.Next(1, 3);
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
