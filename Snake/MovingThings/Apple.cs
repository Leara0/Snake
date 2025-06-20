namespace Snake.MovingThings;

public static class Apple
{
    public static (int x, int y) MakeApple()
    {
        int height = Game.GameBoardSize.height;
        int width = Game.GameBoardSize.width;

        var rnd = new Random();

        var appleX = rnd.Next(2, width-1);
        var appleY = rnd.Next(2, height-1);
        
        Draw.WriteApple((appleX, appleY));

        return (appleX, appleY);
    }

    public static void ManageApple()
    {
        //check if snake has eatten apple
        // if so, add link to snake
        // and make new apple
        // if not, rewrite apple
        
        if (Game.SnakeLinkCoords[0] == Game.Apple ||Game.SnakeLinkCoords[0] == (Game.Apple.x+1, Game.Apple.y))
        {//I included the apple spot and the spot to the right because my unicode apple is 2x wide
            Game.SnakeLength++;
            Game.Apple = MakeApple();
            Game.Score += 100;
        }
        else
        {
            Draw.WriteApple(Game.Apple);
        }
    }
}