using System.Net.Mime;

namespace Snake;

public class TextManager
{
    public const string SnakeLine1 = "~^~^~^~^~^~^>";
    public const string SnakeLine2 = "^~^~^~^~^~^~>";
    public const string Snake1 = @" ____              _        ";
    public const string Snake2 = @"/ ___| _ __   __ _| | _____ ";
    public const string Snake3 = @"\___ \| '_ \ / _` | |/ / _ \";
    public const string Snake4 = @"  ___) | | | | (_| | <|  __/";
    public const string Snake5 = @"|____/|_| |_|\__,_|_|\_\___|";


public static void WelcomeMessage()
{
    TextCenter("Welcome to ", -6);
    TextCenter(Snake1, -5);
    TextCenter(Snake2, -4);
    TextCenter(Snake3, -3);
    TextCenter(Snake4, -2);
    TextCenter(Snake5, -1);
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
    Console.SetCursorPosition(0, Game.GameBoardSize.height - 1); //this puts the 'process finished...'
    //text at the bottom of the frame
    Console.Write(" ");
}

public static void
    TextCenter(string text,
        int y) //writes text in the horizontal center of the screen, and y from the center of screen
{
    int length = text.Length / 2;
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.SetCursorPosition(Game.GameBoardSize.width / 2 - length, Game.GameBoardSize.height / 2 + y);
    Console.WriteLine(text);
}


}