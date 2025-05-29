using System.Net.Mime;

namespace Snake;

public class TextManager
{


public static void WelcomeMessage()
{
    FormatText.TextCenter("Welcome to ", -6);
    FormatText.TextCenter(Text.Snake1, -5);
    FormatText.TextCenter(Text.Snake2, -4);
    FormatText.TextCenter(Text.Snake3, -3);
    FormatText.TextCenter(Text.Snake4, -2);
    FormatText.TextCenter(Text.Snake5, -1);
    FormatText.TextCenter("By Arael Seher", 0);
    FormatText.TextCenter("Press any key to continue...", 1);
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
    FormatText.TextCenter(message, -1);
    FormatText.TextCenter(score, 1);
    Console.SetCursorPosition(0, Game.GameBoardSize.height - 1); //this puts the 'process finished...'
    //text at the bottom of the frame
    Console.Write(" ");
}




}