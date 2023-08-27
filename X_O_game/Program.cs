using X_O_game;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> elementNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        Board board = new Board();
        //Board.drawBoardList();
        Console.WriteLine();
        int player = StartGameMenu.whoStart();

        for(int i = 0; i < elementNumber.Count; i++)
        {
            

            Game.changeBoardList(2, elementNumber, Game.playerTurn(player));
            if(player == 1)
            {
                player = 2;
            }
            else
            {
                player = 1;
            }
        }

        
        
    }
}