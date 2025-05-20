using System.Net.Mime;
using Snake.MovingThings;

namespace Snake;

public class PlayGame
{
    public static void PlayTheGame()
    {
        Scenes.Intro();
        Console.Clear();
        MakeBoard.DrawBoard();

        Scenes.DirectionThreadStarter();

        var avoidEdge = true;

        while (avoidEdge) //at the same time, constantly run this on the main thread
        {
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