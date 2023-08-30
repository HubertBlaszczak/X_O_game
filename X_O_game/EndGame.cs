using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class EndGame
    {
        public static bool conditionOfEndGame(List<string> elementNumber, bool game, int playerTurn)
        {
            if (playerTurn == 1)
            {
                if (elementNumber[0] == "x" && elementNumber[1] == "x" && elementNumber[2] == "x")
                {
                    Console.WriteLine("Wygrał player1, gratulacje ");
                    return false;
                }
                else if (elementNumber[3] == "x" && elementNumber[4] == "x" && elementNumber[5] == "x")
                {
                    Console.WriteLine("Wygrał player1, gratulacje ");
                    return false;
                }
                else if (elementNumber[6] == "x" && elementNumber[7] == "x" && elementNumber[8] == "x")
                {
                    Console.WriteLine("Wygrał player1, gratulacje ");
                    return false;
                }
                else if (elementNumber[0] == "x" && elementNumber[4] == "x" && elementNumber[8] == "x")
                {
                    Console.WriteLine("Wygrał player1, gratulacje ");
                    return false;
                }
                else if (elementNumber[2] == "x" && elementNumber[4] == "x" && elementNumber[6] == "x")
                {
                    Console.WriteLine("Wygrał player1, gratulacje ");
                    return false;
                }

            }
            else if(playerTurn == 2)
            {
                if (elementNumber[0] == "o" && elementNumber[1] == "o" && elementNumber[2] == "o")
                {
                    Console.WriteLine("Wygrał player2, gratulacje ");
                    return false;
                }
                else if (elementNumber[3] == "o" && elementNumber[4] == "o" && elementNumber[5] == "o")
                {
                    Console.WriteLine("Wygrał player2, gratulacje ");
                    return false;
                }
                else if (elementNumber[6] == "o" && elementNumber[7] == "o" && elementNumber[8] == "o")
                {
                    Console.WriteLine("Wygrał player2, gratulacje ");
                    return false;
                }
                else if (elementNumber[0] == "o" && elementNumber[4] == "o" && elementNumber[8] == "o")
                {
                    Console.WriteLine("Wygrał player2, gratulacje ");
                    return false;
                }
                else if (elementNumber[2] == "o" && elementNumber[4] == "o" && elementNumber[6] == "o")
                {
                    Console.WriteLine("Wygrał player2, gratulacje ");
                    return false;
                }
            }
            else if(playerTurn == 3)
            {
                if (elementNumber[0] == "o" && elementNumber[1] == "o" && elementNumber[2] == "o")
                {
                    Console.WriteLine("Wygrał komputer, gratulacje ");
                    return false;
                }
                else if (elementNumber[3] == "o" && elementNumber[4] == "o" && elementNumber[5] == "o")
                {
                    Console.WriteLine("Wygrał komputer, gratulacje ");
                    return false;
                }
                else if (elementNumber[6] == "o" && elementNumber[7] == "o" && elementNumber[8] == "o")
                {
                    Console.WriteLine("Wygrał komputer, gratulacje ");
                    return false;
                }
                else if (elementNumber[0] == "o" && elementNumber[4] == "o" && elementNumber[8] == "o")
                {
                    Console.WriteLine("Wygrał komputer, gratulacje ");
                    return false;
                }
                else if (elementNumber[2] == "o" && elementNumber[4] == "o" && elementNumber[6] == "o")
                {
                    Console.WriteLine("Wygrał komputer, gratulacje ");
                    return false;
                }
            }
            return true;
        }
    }
}
