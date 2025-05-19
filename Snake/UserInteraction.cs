namespace Snake;

public static class UserInteraction
{
    public static void DirectionChoice()
    {
        while (true)
        {
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (!IsOpposite(Game.DirectionHeaded, Game.Direction.Up))
                        Game.NextDirection = Game.Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (!IsOpposite(Game.DirectionHeaded, Game.Direction.Down))
                        Game.NextDirection = Game.Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (!IsOpposite(Game.DirectionHeaded, Game.Direction.Left))
                        Game.NextDirection = Game.Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (!IsOpposite(Game.DirectionHeaded, Game.Direction.Right))
                        Game.NextDirection = Game.Direction.Right;
                    break;
            }
            Thread.Sleep(10); // this sleep is here so the console gets a rest and isn't overwhelmed by checking
            // for direction change
        }
    }

    public static bool IsOpposite(Game.Direction current, Game.Direction next)
    {
        return (current == Game.Direction.Up && next == Game.Direction.Down) || 
               (current == Game.Direction.Down && next == Game.Direction.Up) ||
               (current == Game.Direction.Left && next == Game.Direction.Right)||
               (current == Game.Direction.Right && next == Game.Direction.Left);
    }
}