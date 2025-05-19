using System.Net.Mime;
using Snake.MovingThings;

namespace Snake;

public class PlayGame
{
    
    
    public static void PlayTheGame()
    {
        Console.CursorVisible = false;
        Game.DirectionHeaded = Game.Direction.Right;
        TextManager.WelcomeMessage();
        Console.ReadKey();
        
        //starts background thread to listen for user input
        var changeDirection = new Thread(UserInteraction.DirectionChoice);
        changeDirection.IsBackground =
            true; // thread runs in the background (won't block program execution or termination)
        MovingThings.Snake.StartSnake(); //creates first segment
        changeDirection.Start(); // start this thread
        var avoidEdge = true;
        
        while (avoidEdge) //at the same time, constantly run this on the main thread
        {
            Console.Clear();
            MakeBoard.DrawBoard();
            
            TextManager.WriteScore();
            if (Game.NextDirection.HasValue)
            {
                Game.DirectionHeaded = Game.NextDirection.Value;
                Game.NextDirection = null;
            }
            MovingThings.Snake.MoveSnake();
            
            Apple.ManageApple();

            avoidEdge = KillingSnake.AvoidEdge();

            SpeedModulator.SleepThreader();
        }
        TextManager.EndGameMessage();
    }
}