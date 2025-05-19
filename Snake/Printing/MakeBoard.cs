namespace Snake;

public class MakeBoard
{
    //60x30 is the goal but must check for console size
    // if width is greater than 60 then set it to 60
    // if height is greater than 30 then set it to 30
    // write a line of "|" or "-" to make up the boarders of the play area

    public static (int width, int height) SetSize()
    {
        var height= Math.Min(30, Console.WindowHeight - 1);
        var width= Math.Min(60, Console.WindowWidth - 1);
        return (width, height);
    }

    public static void DrawBoard()
    {
        Console.ForegroundColor = ConsoleColor.White;
        for (var i = 0; i < Game.GameBoardSize.width; i++) 
        {
            Console.SetCursorPosition(i, 0); //top of board
            Console.Write("\u2550");
            
            Console.SetCursorPosition(i, Game.GameBoardSize.height); // bottom of board
            Console.Write("\u2550");
        }

        for (var i = 0; i < Game.GameBoardSize.height; i++)
        {
            Console.SetCursorPosition(0, i); //left side
            Console.Write("\u2551");
            
            Console.SetCursorPosition(Game.GameBoardSize.width, i); //right side
            Console.Write("\u2551");
        }
        // corners:
        Console.SetCursorPosition(0, 0); Console.Write("\u2554");
        Console.SetCursorPosition(0, Game.GameBoardSize.height); Console.Write("\u255A");
        Console.SetCursorPosition(Game.GameBoardSize.width, Game.GameBoardSize.height);
        Console.Write("\u255D");
        Console.SetCursorPosition(Game.GameBoardSize.width, 0); Console.Write("\u2557");
    }
}