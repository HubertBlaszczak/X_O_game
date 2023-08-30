using System.Linq.Expressions;
using X_O_game;

internal class Program
{
    private static void Main(string[] args)
    {

        //StartGameMenu.whoPlay();
        int whoPlay = StartGameMenu.whoPlay();
        int startTurn = StartGameMenu.whoStart(whoPlay);

        List<string> elementNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //Board board = new Board();
        Board.drawBoardList(elementNumber);        
        Console.WriteLine();
        
            //int fieldToChange;
            bool game = true;
        int playerTurn = startTurn;

            while (game)
            {
                
                playerTurn = MainGame.gameMethod(whoPlay, elementNumber, playerTurn);
                game = EndGame.conditionOfEndGame(elementNumber, game, playerTurn);

            //playerTurn = MainGame.changeTurn(whoPlay, playerTurn);
        }

        return;
    }
}