using System.Media;

namespace Snake;

public static class Music
{
    private static SoundPlayer musicPlayer;

    public static void PlayMusic()
    {
        musicPlayer = new SoundPlayer("Assets/Bit Quest.wav");
        musicPlayer.Load();
        musicPlayer.PlayLooping();//loops song for cont play
    }

    public static void StopMusic()
    {
        musicPlayer?.Stop();
    }
}