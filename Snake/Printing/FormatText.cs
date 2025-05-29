namespace Snake;

public class FormatText
{
    public static void  TextCenter(string text,  int y) 
        //writes text in the horizontal center of the screen, and y from the center of screen
    {
        int length = text.Length / 2;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(Game.GameBoardSize.width / 2 - length, Game.GameBoardSize.height / 2 + y);
        Console.WriteLine(text);
    }

    public static void Print(string text)
    {
        int length = text.Length / 2;
        int yPosn = Math.Min(Console.CursorTop, Console.WindowHeight - 1);
        int xPosn = Math.Max(0, Game.GameBoardSize.width / 2 - length);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(xPosn, yPosn);
        Console.WriteLine(text);
    }
}