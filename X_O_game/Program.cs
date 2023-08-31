using System.Linq.Expressions;
using X_O_game;

internal class Program
{
    private static void Main(string[] args)
    {        
        int whoPlay = StartGameMenu.whoPlay();
        int playerTurn = StartGameMenu.whoStart(whoPlay);
        bool game = true;

        List<string> elementNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };         
        Board.drawBoardList(elementNumber);         
                
        while (game)
            {
                var mainGame = MainGame.gameMethod(whoPlay, elementNumber, playerTurn, game);
                playerTurn = mainGame.playerTurn;
                game = mainGame.game;
            }   

        return;
    }
}