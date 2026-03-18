using System;

public class AchievementSystem
{
    private bool halfHealthUnlocked = false;
    private bool firstDeathUnlocked = false;

    public void Subscribe(Player player)
    {
        player.DamageTaken += CheckAchievements;
    }

    private void CheckAchievements(int damage, int currentHP)
    {
        if (currentHP <= 50 && !halfHealthUnlocked)
        {
            Console.WriteLine("Achievement: 🏆 Half Health");
            halfHealthUnlocked = true;
        }

        if (currentHP <= 0 && !firstDeathUnlocked)
        {
            Console.WriteLine("Achievement: 💀 First Death");
            firstDeathUnlocked = true;
        }
    }
}