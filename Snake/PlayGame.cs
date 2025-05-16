using Snake.MovingThings;

namespace Snake;

public class PlayGame
{
    
    
    public static void PlayTheGame()
    {
        Console.CursorVisible = false;
        Game.DirectionHeaded = Game.Direction.Right;
        
        //starts background thread to listen for user input
        var changeDirection = new Thread(UserInteraction.DirectionChoice);
        changeDirection.IsBackground =
            true; // thread runs in the background (won't block program execution or termination)
        MovingThings.Snake.StartSnake(); //creates first segment
        changeDirection.Start(); // start this thread
        var avoidEdge = true;
        
        while (avoidEdge) //at the same time, constantly run this on the main thread
        {
            Game.AcceptDirectionChg = true;
            Console.Clear();
            MakeBoard.DrawBoard();
            
            MovingThings.Snake.MoveSnake();
            Apple.ManageApple();

            //handle snake movement and apple eating

            avoidEdge = KillingSnake.AvoidEdge();

            Thread.Sleep(200);
        }
    }
}