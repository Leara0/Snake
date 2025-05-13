using Snake;

namespace TestProject1;

public class AppleTest
{
   [Fact]
   public void MakeAppleReturnsCoordsWithinBounds()
   {
      var (x, y) = AppleGen.MakeApple();
      int expectedWidth = Console.IsOutputRedirected ? 80 : Console.WindowWidth;
      int expectedHeight = Console.IsOutputRedirected ? 80 : Console.WindowHeight;
      
      Assert.InRange(x, 0, expectedWidth-1);
      Assert.InRange(y, 0, expectedHeight-1);
   }
}