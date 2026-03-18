using System;

class Program
{
    static void Main()
    {
        Player player = new Player(100);

        UIHealthBar ui = new UIHealthBar();
        SoundSystem sound = new SoundSystem();
        AchievementSystem achievements = new AchievementSystem();
        GameLogger logger = new GameLogger();

        ui.Subscribe(player);
        sound.Subscribe(player);
        achievements.Subscribe(player);
        logger.Subscribe(player);

        player.TakeDamage(20);
        Console.WriteLine();

        player.TakeDamage(30);
        Console.WriteLine();

        player.TakeDamage(40);
        Console.WriteLine();

        player.TakeDamage(20);
    }
}