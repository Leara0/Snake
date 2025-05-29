namespace Snake;

public class Scenes
{
    public static void Intro()
    {
        Console.CursorVisible = false;
        ScreenSizeCheck.Check();
        Game.DirectionHeaded = Game.Direction.Right;
        Console.Clear();
        
        TextManager.WelcomeMessage();
        MakeBoard.DrawBoard();
        
        
        Console.ReadKey();
        

    }

    public static void DirectionThreadStarter()
    {
        //starts background thread to listen for user input
        var changeDirection = new Thread(UserInteraction.DirectionChoice);
        changeDirection.IsBackground =
            true; // thread runs in the background (won't block program execution or termination)
        MovingThings.Snake.StartSnake(); //creates first segment
        changeDirection.Start(); // start this thread
    }
}