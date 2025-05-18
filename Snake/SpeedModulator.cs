namespace Snake;

public class SpeedModulator
{
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

        if (Game.Score < 800)
        {
            if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
                Thread.Sleep(90);
            if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
                Thread.Sleep(170);
            return;
        }
        if (Game.Score <= 1200)
        {
            if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
                Thread.Sleep(50);
            if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
                Thread.Sleep(90);
            return;
        }
        if (Game.Score <= 1600)
        {
            if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
                Thread.Sleep(25);
            if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
                Thread.Sleep(40);
            return;
        }
    }
}