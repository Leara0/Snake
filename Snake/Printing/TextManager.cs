using System.Net.Mime;

namespace Snake;

public class TextManager
{
    public static void WelcomeMessage()
    {
        TextCenter("Welcome to Snake!", -1);
        TextCenter("By Arael Seher", 0);
        TextCenter("Press any key to continue...", 1);
    }
    public static void WriteScore()
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"Current score: {Game.Score}");
        Console.ResetColor();
    }
     
    public static void EndGameMessage()
    {
        string message = "GAME OVER";
        string score = $"Your score is: {Game.Score}";
        TextCenter(message, -1);
        TextCenter(score, 1);
        Console.SetCursorPosition(0, Game.GameBoardSize.height-1);//this puts the 'process finished...'
                                                                  //text at the bottom of the frame
        Console.Write(" ");
    }

    public static void TextCenter(string text, int y)
    {
        int length = text.Length/2;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(Game.GameBoardSize.width/2 - length, Game.GameBoardSize.height/2 + y);
        Console.WriteLine(text);
        
    }

    public static void WriteSnakeAsciiArt()
    {
        Console.WriteLine(@"
  ____ ~^~^~^~^~^~^>_        
 / ___| _ __   __ _| | _____ 
 \___ \| '_ \ / _` | |/ / _ \
  ___) | | | | (_| |   <  __/
 |____/|_| |_|\__,_|_|\_\___|");
    }
}