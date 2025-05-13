namespace Snake;

public class PlayGame
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    };

    public static Direction DirectionHeaded { get; set; }
    public static List<(int x, int y)> SnakeLinkCoords = new List<(int x, int y)>();
    public static void PlayTheGame()
    {
        var apple = AppleGen.MakeApple(); // this won't go here 
        DirectionHeaded = Direction.Right;
       
        //starts background thread to listen for user input
        Thread changeDirection = new Thread(UserInteractionChgDirection.ChangeDirection);
        changeDirection.IsBackground = true; // thread runs in the background (won't block program execution or termination)
        changeDirection.Start(); // start this thread

        while (true) //at the same time, constantly run this on the main thread
        {
            //handle snake movement and apple eating
            Thread.Sleep(400);
        }
    }
}