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
        for (var i = 0; i < Game.GameBoardSize.width; i++) 
        {
            Console.SetCursorPosition(i, 0); //top of board
            Console.Write('-');
            
            Console.SetCursorPosition(i, Game.GameBoardSize.height); // bottom of board
            Console.Write('-');
        }

        for (var i = 0; i < Game.GameBoardSize.height; i++)
        {
            Console.SetCursorPosition(0, i); //left side
            Console.Write('|');
            
            Console.SetCursorPosition(Game.GameBoardSize.width, i); //right side
            Console.Write('|');
        }
    }
}