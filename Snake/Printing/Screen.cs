namespace Snake;

public class Screen
{
    public static void DrawSnake(int x, int y) // x and y are new coords for next head segment
    {
        Game.SnakeLinkCoords.Insert(0, (x, y)); //adds new head segment onto body list

        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var link in Game.SnakeLinkCoords) //draws snake body 
        {
            Console.SetCursorPosition(link.x, link.y);
            Console.Write("X");
        }

        Console.ResetColor();

        if (Game.SnakeLinkCoords.Count >= Game.SnakeLength) //erases then trims tail
        {
            (int tailX, int tailY) = Game.SnakeLinkCoords[Game.SnakeLinkCoords.Count - 1];
            Console.SetCursorPosition(tailX, tailY);
            Console.Write(" ");
            Game.SnakeLinkCoords.RemoveAt(Game.SnakeLinkCoords.Count - 1);
        }
    }
    
    public static void WriteApple((int x, int y) apple)
    {
        Console.SetCursorPosition(apple.x, apple.y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("🍎");
        Console.ResetColor();
    }
}