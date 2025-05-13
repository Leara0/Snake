namespace Snake;

public class UserInteractionChgDirection
{
    public static void ChangeDirection()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        PlayGame.DirectionHeaded = PlayGame.Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        PlayGame.DirectionHeaded = PlayGame.Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        PlayGame.DirectionHeaded = PlayGame.Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        PlayGame.DirectionHeaded = PlayGame.Direction.Right;
                        break;
                }
            }

            Thread.Sleep(10);
        }
    }
}