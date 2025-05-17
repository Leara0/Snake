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
            Console.SetCursorPosition(0, 0);
            Console.Write($"Current score: {Game.Score}");
            
            MovingThings.Snake.MoveSnake();
            Apple.ManageApple();

            avoidEdge = KillingSnake.AvoidEdge();

            SleepThreader();
        }
    }

    public static void SleepThreader()
    {
        if (Game.Score < 400)
        {
            if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
                Thread.Sleep(150);
            if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
                Thread.Sleep(280);
            return;
        }

        if (Game.Score < 700)
        {
            if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
                Thread.Sleep(90);
            if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
                Thread.Sleep(170);
            return;
        }
        if (Game.Score <= 1000)
        {
            if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
                Thread.Sleep(50);
            if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
                Thread.Sleep(900);
            return;
        }
        if (Game.Score <= 1300)
        {
            if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
                Thread.Sleep(25);
            if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
                Thread.Sleep(40);
            return;
        }
    }
}