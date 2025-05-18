namespace Snake;

public class TextManager
{
    public static void WriteScore()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"Current score: {Game.Score}");
        Console.ResetColor();
    }
     
    public static void EndGameMessage()
    {
        string message = "GAME OVER";
        string score = $"Your score is: {Game.Score}";
        Console.SetCursorPosition(Game.GameBoardSize.width/2-(message.Length/2), Game.GameBoardSize.height/2-1);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(message);
        Console.SetCursorPosition(Game.GameBoardSize.width/2-score.Length/2, Game.GameBoardSize.height/2+1);
        Console.WriteLine(score);
        Console.SetCursorPosition(0, Game.GameBoardSize.height-1);//this puts the 'process finished...'
                                                                  //text at the bottom of the frame
        Console.Write(" ");
    }
}