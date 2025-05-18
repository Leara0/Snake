namespace Snake;

public static class UserInteraction
{
    public static void DirectionChoice()
    {
        while (true)
        {
            if (Game.AcceptingDirection)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Game.DirectionHeaded == Game.Direction.Left ||
                            Game.DirectionHeaded == Game.Direction.Right)
                            Game.DirectionHeaded = Game.Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        if (Game.DirectionHeaded == Game.Direction.Left ||
                            Game.DirectionHeaded == Game.Direction.Right)
                            Game.DirectionHeaded = Game.Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Game.DirectionHeaded == Game.Direction.Down ||
                            Game.DirectionHeaded == Game.Direction.Up)
                            Game.DirectionHeaded = Game.Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        if (Game.DirectionHeaded == Game.Direction.Down ||
                            Game.DirectionHeaded == Game.Direction.Up)
                            Game.DirectionHeaded = Game.Direction.Right;
                        break;
                }
                Game.AcceptingDirection = false;
            }

            Thread.Sleep(10); // this sleep is here so the console gets a rest and isn't overwhelmed by checking
            // for direction change
        }
    }
}