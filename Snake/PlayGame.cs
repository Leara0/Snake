using System.Net.Mime;
using Snake.MovingThings;

namespace Snake;

public class PlayGame
{
    
    
    public static void PlayTheGame()
    {
        Scenes.Intro();
        
        Scenes.DirectionThreadStarter();
        
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