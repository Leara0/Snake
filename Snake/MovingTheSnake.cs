namespace Snake;

public class MovingTheSnake
{
    /*move the snake
    - clear screen between movement (remember to rewrite apple)
        - use a list to store coord for each segment
    + add new segment to end (.Add()) and remove old segment from begining (.RemoveAt[0])
    - continue on in the direction snake has been going
    steer the snake when direction is pressed
    - only responds if perpendicular direction is pressed
    - responds and changes direction of snake
    generate a new apple when one is eaten
    - new coord generated and printed (print every time screen is cleared)
    grow the snake when apple is eaten
    - overwrite or skip the remove old segment
        kill the game if the snake hits itself or the wall
    - check if snake List<(int X, int Y)> contains new coord or if it is outside window height or width*/


    public static void SnakeMover()
    {
        string snakeLink = "x";


        // start snake
    }

    public static (int x, int y) StartSnake() //8 segments long
    {
        string snakeLink = "x";
        int height = Console.WindowHeight / 2;
        
       (int x, int y) position = (0, height);
        Console.SetCursorPosition(position.x, position.y);
        Console.Write(snakeLink);
        PlayGame.SnakeLinkCoords.Add(position);
        
        return (position);
    }


    public static void MoveSnake()
    {
        var head = PlayGame.SnakeLinkCoords[0];
        int x = head.x;
        int y = head.y;
        switch (PlayGame.DirectionHeaded)
        {
            case PlayGame.Direction.Left:
                x--;
                break;
            case PlayGame.Direction.Right:
                x++;
                break;
            case PlayGame.Direction.Up:
                y--;
                break;
            case PlayGame.Direction.Down:
                y++;
                break;
        }
        PlayGame.SnakeLinkCoords.Insert(0, (x, y));
    }
}