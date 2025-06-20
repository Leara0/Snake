namespace Snake;

public static class Game // I made a class to store all the properties that are used across the game
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    public static bool AcceptingDirection { get; set; } = true;

    public static int Score { get; set; } = 0;

    public static List<(int x, int y)> SnakeLinkCoords = new();
    public static int SnakeLength { get; set; } = 9;
    
    public static Direction DirectionHeaded { get; set; }
    public static Direction? NextDirection { get; set; }

    public static (int width, int height) GameBoardSize { get; set; } = MakeBoard.SetSize();
    public static (int x, int y) Apple { get; set; } = MovingThings.Apple.MakeApple(); // set the first apple
}