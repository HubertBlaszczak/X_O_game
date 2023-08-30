using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class StartGameMenu
    {

        /// <summary>
        /// Method to choose game mode PvP(1) or PvComputer(2)
        /// </summary>
        /// <param name="whoPlay"></param>
        /// <returns></returns>
        
        public static int whoPlay()
        {
            Console.WriteLine("Wybierz z kim chcesz zagrać (wpisz 1 lub 2): ");
            Console.WriteLine("1. Player1 vs Player2 ");
            Console.WriteLine("2. Player1 vs Computer ");
            int.TryParse(Console.ReadLine(), out int whoPlay);
            int player;
            if (whoPlay == 1)
            {
                player = 1;                
            }
            else 
            {
                player = 2;
            }
            return player;
        }
        /// <summary>
        /// Random method to choose who will be start the game
        /// </summary>
        /// <returns></returns>
        public static int whoStart( int player)
        {
            Random random = new Random();
            int startPlayerTurn = 1;
            if (player == 1 ) 
            {
                startPlayerTurn = random.Next(1, 3);
            }
            else if (player == 2)
            {
                int[] playerturn = { 1, 3 };
                int randomTurn = random.Next(0, 2);
                startPlayerTurn = playerturn[randomTurn];

            }
                        
            return startPlayerTurn;
        }
    }
}
