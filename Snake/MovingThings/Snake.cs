namespace Snake.MovingThings;

public static class Snake
{
    public static void StartSnake()
    {
        var height = Console.WindowHeight / 2;

        var (x, y) = (1, height);
        Draw.DrawSnake(x, y);
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
        {
            TextManager.EndGameMessage();
            Environment.Exit(0);//ends game if snake hits self
            
        } 
        Draw.DrawSnake(x, y);
    }
}