namespace Snake;

public class Screen
{
    public static void DrawSnake(int x, int y) // x and y are new coords for next head segment
    {
        Game.SnakeLinkCoords.Insert(0, (x, y)); //adds new head segment onto body list

        Console.ForegroundColor = ConsoleColor.Green;
        
        //print head and body
        for (var i = 0; i < Game.SnakeLinkCoords.Count; i++) //draws snake body 
        {
            (int snakeX, int snakeY) = Game.SnakeLinkCoords[i];
            Console.SetCursorPosition(snakeX, snakeY);

            if (i % 2 == 1) // separates even and odd links to make alternating color
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\u25cf");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\u25c9");
            }
        }

        if (Game.SnakeLinkCoords.Count > Game.SnakeLength)
        {
            (int tailX, int tailY) = Game.SnakeLinkCoords[Game.SnakeLinkCoords.Count - 1];
            Console.SetCursorPosition(tailX, tailY);
            Console.Write(" ");
            Game.SnakeLinkCoords.RemoveAt(Game.SnakeLinkCoords.Count - 1);
        }

        Console.ResetColor();
    }

    public static void WriteApple((int x, int y) apple)
    {
        Console.SetCursorPosition(apple.x, apple.y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("🍎");
        Console.ResetColor();
    }
}