using System.Linq.Expressions;
using X_O_game;

internal class Program
{
    private static void Main(string[] args)
    {        
        int whoPlay = StartGameMenu.whoPlay();
        int startTurn = StartGameMenu.whoStart(whoPlay);

        List<string> elementNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };        
        Board.drawBoardList(elementNumber);        
        Console.WriteLine();           
        bool game = true;
        int playerTurn = startTurn;

            while (game)
            {
            
            var mainGame = MainGame.gameMethod(whoPlay, elementNumber, playerTurn, game);
            playerTurn = mainGame.playerTurn;
            game = mainGame.game;
            //playerTurn = MainGame.gameMethod(whoPlay, elementNumber, playerTurn, game);
            //game = EndGame.conditionOfEndGame(elementNumber, playerTurn);


        }   

        return;
    }
}