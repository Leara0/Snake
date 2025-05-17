namespace Snake.MovingThings;

public static class Apple
{
    public static (int x, int y) MakeApple()
    {
        int height = Game.GameBoardSize.height;
        int width = Game.GameBoardSize.width;

        var rnd = new Random();

        var appleX = rnd.Next(2, width-1);
        var appleY = rnd.Next(2, height-1);
        if (!Console.IsInputRedirected)
        {
            Console.SetCursorPosition(appleX, appleY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ó"); //writes an apple to screen at apple spot
            Console.ResetColor();
        }

        return (appleX, appleY);
    }

    public static void WriteApple((int x, int y) apple)
    {
        Console.SetCursorPosition(apple.x, apple.y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ó");
        Console.ResetColor();
    }

    public static void ManageApple()
    {
        //check if snake has eatten apple
        // if so, add link to snake
        // and make new apple
        // if not, rewrite apple
        if (Game.SnakeLinkCoords[0] == Game.Apple)
        {
            Game.SnakeLength++;
            Game.Apple = MakeApple();
            Game.Score += 100;
        }
        else
        {
            WriteApple(Game.Apple);
        }
    }
}