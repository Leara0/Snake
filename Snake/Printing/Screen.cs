namespace Snake;

public class Screen
{
    public static void DrawSnake(int x, int y)
    {
        Game.SnakeLinkCoords.Insert(0, (x, y)); //adds head onto body list

        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var link in Game.SnakeLinkCoords) //draws snake
        {
            Console.SetCursorPosition(link.x, link.y);
            Console.Write("X");
        }

        Console.ResetColor();

        if (Game.SnakeLinkCoords.Count >= Game.SnakeLength) //trims tail
            Game.SnakeLinkCoords.RemoveAt(Game.SnakeLinkCoords.Count - 1);
    }
    
    public static void WriteApple((int x, int y) apple)
    {
        Console.SetCursorPosition(apple.x, apple.y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("@");
        Console.ResetColor();
    }
}