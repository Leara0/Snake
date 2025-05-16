namespace Snake;

public class KillingSnake
{
    public static bool AvoidEdge()
    {
        var (x, y) = Game.SnakeLinkCoords[0];
        var checkX = x < Game.GameBoardSize.width - 1 && x > 1;
        var checkY = y < Game.GameBoardSize.height - 1 && y > 1;
        return checkX && checkY;
    }


    public static bool AvoidSnake((int x, int y) head)
    {
        //if head is in list of body then end game
        if (Game.SnakeLinkCoords.Contains(head))
            return false;
        return true;
    }
}