namespace Snake.MovingThings;

public static class Snake
{
    private static void DrawSnake(int x, int y)
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

    public static void StartSnake()
    {
        var height = Console.WindowHeight / 2;

        var (x, y) = (1, height);
        DrawSnake(x, y);
    }

    public static void MoveSnake()
    {
        var head = Game.SnakeLinkCoords[0];
        var x = head.x;
        var y = head.y;
        switch (Game.DirectionHeaded)
        {
            case Game.Direction.Left:
                x--;
                break;
            case Game.Direction.Right:
                x++;
                break;
            case Game.Direction.Up:
                y--;
                break;
            case Game.Direction.Down:
                y++;
                break;
        }

        var snakeHead = (x, y);
        if (!KillingSnake.AvoidSnake(snakeHead))
            Environment.Exit(0); //ends game if snake hits self
        DrawSnake(x, y);
    }
}