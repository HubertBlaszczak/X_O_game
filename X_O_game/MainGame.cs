using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_game;

namespace X_O_game
{
    internal class MainGame
    {
        public static (int playerTurn, bool game) gameMethod(int whoPlay, List<string> elementNumber, int playerTurn, bool game)
        {
            if (game == true)
            {
                Random random = new Random();

                if (playerTurn == 1)
                {
                    Console.WriteLine("Player 1: ");
                    Console.WriteLine("Podaj numer pola w którym chcesz postawić znak: ");
                    if (int.TryParse(Console.ReadLine(), out int fieldToChange))
                    {

                        if (0 <= fieldToChange && fieldToChange < 10)
                        {
                            if (int.TryParse(elementNumber[fieldToChange - 1], out int result))
                            {
                                Game.changeBoardList(fieldToChange - 1, elementNumber, playerTurn);
                                game = EndGame.conditionOfEndGame(elementNumber, playerTurn);
                                if (game == true)
                                {
                                    playerTurn = changeTurn(whoPlay, playerTurn);

                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Podano niepoprawny numer pola, podaj numer pola dostępny na planszy");
                                Board.drawBoardList(elementNumber);
                                Console.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podano niepoprawny numer pola, podaj numer pola dostępny na planszy");
                    }

                }
                else if (playerTurn == 2)
                {
                    Console.WriteLine("Player 2: ");
                    Console.WriteLine("Podaj numer pola w którym chcesz postawić znak: ");
                    if (int.TryParse(Console.ReadLine(), out int fieldToChange))
                    {
                        if (0 <= fieldToChange && fieldToChange < 10)
                        {
                            if (int.TryParse(elementNumber[fieldToChange - 1], out int result))
                            {
                                Game.changeBoardList(fieldToChange - 1, elementNumber, playerTurn);
                                game = EndGame.conditionOfEndGame(elementNumber, playerTurn);
                                if (game == true)
                                {
                                    playerTurn = changeTurn(whoPlay, playerTurn);

                                    Console.WriteLine();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Podano niepoprawny numer pola, podaj numer pola dostępny na planszy");
                                Board.drawBoardList(elementNumber);
                                Console.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podano niepoprawny numer pola, podaj numer pola dostępny na planszy");
                    }
                }
                else if (playerTurn == 3)
                {

                    {
                        int fieldToChange = random.Next(1, elementNumber.Count + 1);
                        if (0 <= fieldToChange && fieldToChange < 10)
                        {
                            if (int.TryParse(elementNumber[fieldToChange - 1], out int result))
                            {
                                Console.WriteLine("Komputer wybrał pole: " + fieldToChange);
                                Game.changeBoardList(fieldToChange - 1, elementNumber, playerTurn);
                                game = EndGame.conditionOfEndGame(elementNumber, playerTurn);
                                if (game == true)
                                {
                                    playerTurn = changeTurn(whoPlay, playerTurn);

                                    Console.WriteLine();
                                }
                            }
                        }
                    }

                }
            }
                return (playerTurn, game);

            
        }
            public static int changeTurn(int whoPlay, int playerTurn)
            {
                if (whoPlay == 1)
                {

                    if (playerTurn == 1)
                    {
                        playerTurn = 2;
                    }
                    else if (playerTurn == 2)
                    {
                        playerTurn = 1;
                    }
                }
                else if (whoPlay == 2)
                {
                    if (playerTurn == 1)
                    {
                        playerTurn = 3;
                    }
                    else if (playerTurn == 3)
                    {
                        playerTurn = 1;
                    }
                }
                return playerTurn;

            }
        }   
        

    }

