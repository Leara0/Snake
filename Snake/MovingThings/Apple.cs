namespace Snake.MovingThings;

public static class Apple
{
    public static (int x, int y) MakeApple()
    {
        int height = Game.GameBoardSize.height;
        int width = Game.GameBoardSize.width;

        var rnd = new Random();

        var appleX = rnd.Next(1, width);
        var appleY = rnd.Next(1, height);
        if (!Console.IsInputRedirected)
        {
            Console.SetCursorPosition(appleX, appleY);
            Console.Write("O"); //writes an apple to screen at apple spot
        }

        return (appleX, appleY);
    }

    public static void WriteApple((int x, int y) apple)
    {
        Console.SetCursorPosition(apple.x, apple.y);
        Console.Write("O");
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
        }
        else
        {
            WriteApple(Game.Apple);
        }
    }
}