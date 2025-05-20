namespace Snake;

public class SpeedModulator
{
    public static void SleepThreader()
    {
        if (Game.DirectionHeaded == Game.Direction.Right || Game.DirectionHeaded == Game.Direction.Left)
            Thread.Sleep(Math.Max(30, 130 - Game.Score / 13));
        if (Game.DirectionHeaded == Game.Direction.Up || Game.DirectionHeaded == Game.Direction.Down)
            Thread.Sleep(Math.Max(50, 270 - Game.Score / 6));
        Console.Write("");
    }
}