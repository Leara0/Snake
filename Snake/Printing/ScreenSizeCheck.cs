namespace Snake;

public class ScreenSizeCheck
{
    public static void Check()
    {
        Console.Clear();
        while (Console.WindowHeight < 6)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            FormatText.Print("Make your window taller!");
            UserInteraction.PressAnyKey();
        }
        while (Console.WindowHeight < 13) // need 4-6 high (and 3 wide)
        {
            Console.Clear();
            FormatText.Print(Text.ScreenTooSmall1);
            FormatText.Print(Text.ScreenTooSmall2);
            FormatText.Print(Text.ScreenTooSmall3);
            FormatText.Print(Text.ScreenTooSmall4);
            UserInteraction.PressAnyKey();
        }

       Game.GameBoardSize = MakeBoard.SetSize();
    }
}