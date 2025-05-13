namespace Snake;

public class AppleGen
{
     public static (int x, int y) MakeApple()
    {
        int width, height;
        if (Console.IsInputRedirected) //for unit testing
        {
            width = 80; //sets values to use during unit testing
            height = 80;
        }
        else
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth; 
        }
        
        Random rnd = new Random();

        int AppleX = rnd.Next(0, width);
        int AppleY = rnd.Next(0, height);
        if (!Console.IsInputRedirected)
        {
            Console.SetCursorPosition(AppleX, AppleY);
            Console.Write("🍎");//writes an apple to screen at apple spot
        }
        
        return (AppleX, AppleY);
    }
}