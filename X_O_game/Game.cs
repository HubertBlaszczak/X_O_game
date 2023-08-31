using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace X_O_game
{
    internal class Game
    {        
        public static void changeBoardList(int field, List<string> elementNumber, int playerTurn)
        {
            

                if (playerTurn == 1)
                {
                    elementNumber[field] = "x";
                }
                else
                {
                    elementNumber[field] = "o";
                }
                for (int i = 0; i < elementNumber.Count; i++)
                {
                    Console.Write(" " + elementNumber[i] + " ");
                    if (i == 2 || i == 5 || i == 8)
                    {
                        Console.WriteLine();
                    }
                }
            
            

        }


        
        
    }
}
